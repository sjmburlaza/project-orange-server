namespace ProjectOrangeApi.Models;

public class CartVoucher
{
  public int Id { get; set; }

  public int CartId { get; set; }
  public Cart Cart { get; set; } = null!;

  public string Code { get; set; } = string.Empty;
  public string Name { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
}