using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Route("api/{siteCode:alpha:length(2)}/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public OrdersController(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
    {
        var orders = await _context.Orders
          .Where(o => o.SiteId == _siteContext.SiteId)
          .Include(o => o.Items)
          .ThenInclude(i => i.Product)
          .ToListAsync();

        return Ok(orders);
    }

    [HttpPost]
    public async Task<ActionResult<Order>> CreateOrder(CreateOrderDto dto)
    {
        if (dto.Items == null || dto.Items.Count == 0)
            return BadRequest("Order must contain at least one item.");

        var productIds = dto.Items.Select(i => i.ProductId).ToList();
        var products = await _context.Products
            .Include(p => p.Category)
            .Include(p => p.ItemSpecs)
            .Where(p =>
                p.SiteId == _siteContext.SiteId &&
                productIds.Contains(p.Id))
            .ToListAsync();

        var order = new Order
        {
            SiteId = _siteContext.SiteId,
            CustomerName = dto.CustomerName,
            CustomerEmail = dto.CustomerEmail,
            Items = new List<OrderItem>()
        };

        decimal total = 0;

        foreach (var item in dto.Items)
        {
            var product = products.FirstOrDefault(p => p.Id == item.ProductId);
            if (product == null)
                return BadRequest($"Product with ID {item.ProductId} not found");

            if (product.StockQuantity < item.Quantity)
                return BadRequest($"Not enough stock for product: {product.Name}");

            product.StockQuantity -= item.Quantity;

            var orderItem = new OrderItem
            {
                ProductId = product.Id,
                Quantity = item.Quantity,
                Price = product.Price
            };

            order.Items.Add(orderItem);
            total += product.Price * item.Quantity;

        }

        order.TotalAmount = total;

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        return Ok(order);
    }
}
