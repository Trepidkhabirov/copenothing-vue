using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pepeapi.Model;
[ApiController]
[Route("api")]
public class BasketController : ControllerBase
{
    [HttpGet("product/showbasket")]
    public IActionResult getBasket()
    {
        var db = new FrogbdContext();
        var baskets = db.Baskets.ToList();
        if (baskets == null)
        {
            return BadRequest( new { message = "Нет продуктов"});
        }
        else
        {
        return Ok(
            baskets
        );  
        }
    }
    [HttpPost("product/addBasket")]
    public IActionResult addBasket(int ProductId, int UserId)
    {
        var db = new FrogbdContext();
               var product = db.Products.FirstOrDefault(p => p.Idproduct == ProductId);
               if (product == null)
        {
            return BadRequest("Товар не найден!");
        }
               var user = db.Users.FirstOrDefault(u => u.Iduser == UserId);
               if (user == null)
        {
            return BadRequest("Пользователь не найден!");
        }
        var basket = db.Baskets.FirstOrDefault(b => b.UserId == UserId && b.ProductId == ProductId);
        if (basket != null)
        {
            basket.Count += 1;
            db.SaveChanges();
            return Ok(new
            {
                message = "Добавлен в корзину!",
                UserId = UserId,
              ProductId = ProductId,
              Count = basket.Count,
              Title = product.Title,
              Image = product.Image,
              Cost =  product.Cost  
            });
        }
            var newbasket = new Basket
            {
              UserId = UserId,
              ProductId = ProductId,
              Count = 1,
              Title = product.Title,
              Image = product.Image,
              Cost =  product.Cost  
            };
            db.Baskets.Add(newbasket);
            db.SaveChanges();
             return Ok(new
            {
               message = "Добавлен в корзину!",
                UserId = UserId,
              ProductId = ProductId,
              Count = newbasket.Count,
              Title = product.Title,
              Image = product.Image,
              Cost =  product.Cost  
            });
    }

}