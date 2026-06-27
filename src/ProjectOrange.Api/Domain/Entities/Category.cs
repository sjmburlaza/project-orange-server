using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProjectOrangeApi.Models;

public class Category
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    [JsonIgnore]
    public string SubcategoriesJson { get; set; } = "[]";

    [NotMapped]
    public List<string> Subcategories
    {
        get => DeserializeSubcategories(SubcategoriesJson);
        set => SubcategoriesJson = JsonSerializer.Serialize(value ?? []);
    }

    public ICollection<Product> Products { get; set; } = new List<Product>();

    private static List<string> DeserializeSubcategories(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        try
        {
            return JsonSerializer.Deserialize<List<string>>(json) ?? [];
        }
        catch (JsonException)
        {
            return [];
        }
    }
}
