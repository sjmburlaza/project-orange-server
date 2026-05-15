namespace ProjectOrangeApi.DTOs;

public class CartResponseDto
{
  public string Code { get; set; } = string.Empty;
  public List<CartItemDto> Entries { get; set; } = [];
  public List<VoucherDto> AppliedVouchers { get; set; } = [];
  public List<CartSummaryAttributeDto> CartSummary { get; set; } = [];
}