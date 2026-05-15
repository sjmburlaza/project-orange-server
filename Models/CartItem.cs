namespace ProjectOrangeApi.Models;

public class CartItem
{
  public int Id { get; set; }

  public int CartId { get; set; }
  public Cart Cart { get; set; } = null!;

  public int ProductId { get; set; }
  public string ProductName { get; set; } = string.Empty;
  public decimal Price { get; set; }
  public int Quantity { get; set; }
  public string ImageUrl { get; set; } = string.Empty;

  public List<CartItemAddon> Addons { get; set; } = [];
}