namespace ProjectOrangeApi.DTOs;

public class AddToCartRequest
{
  public int ProductId { get; set; }
  public string ProductName { get; set; } = string.Empty;
  public decimal Price { get; set; }
  public int Quantity { get; set; }
  public string ImageUrl { get; set; } = string.Empty;
  public List<AddonDto> Addons { get; set; } = [];
}