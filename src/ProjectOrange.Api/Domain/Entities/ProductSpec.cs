namespace ProjectOrangeApi.Models;

public class ProductSpec
{
	public int Id { get; set; }

	public int ProductId { get; set; }
	public Product? Product { get; set; }

	public string Name { get; set; } = string.Empty;
	public string Value { get; set; } = string.Empty;
}