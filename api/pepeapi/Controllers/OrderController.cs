using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pepeapi.Model;
[ApiController]
[Route("api")]
public class OrderController : ControllerBase
{
    [HttpPost("Order/buying")]
    public IActionResult buying(int UserId)
    {
        var db = new FrogbdContext();
        var basket = db.Baskets.Where(b => b.UserId == UserId).ToList();
        int PriceAll = 0;
        foreach (var p in basket)
        {
            PriceAll += p.Cost * p.Count;
        }
        var newOrder = new Order
        {
            PriceAll = PriceAll,
            DateOrder = DateOnly.FromDateTime(DateTime.Now),
            UserId = UserId,
            Status = "Новый",
            AdressDelivery = "Ул Пушкина",
            DateDelivery = DateOnly.FromDateTime(DateTime.Now)
        };
        db.Orders.Add(newOrder);
        db.SaveChanges();
        int orderId = newOrder.Idorder;
        foreach (var product in basket)
        {
        var neworderitems = new OrderItem
        {
          OrderId = orderId,
          ProductId =  product.ProductId,
          Count = product.Count
        };
        db.OrderItems.Add(neworderitems);
        }
        
        db.Baskets.RemoveRange(basket);
        db.SaveChanges();
        return Ok(
            new { message = "Заказ оформлен!"}
        );

        
    }
}