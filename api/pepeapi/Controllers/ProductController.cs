using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pepeapi.Model;
[ApiController]
[Route("api")]
public class ProductController : ControllerBase
{
    [HttpGet("product/showproduct")]
    public IActionResult getProduct()
    {
        var db = new FrogbdContext();
        var products = db.Products.ToList();
        return Ok(
            products
        );
    }
    [HttpPost("product/addproduct")]
    public IActionResult addProduct(Product product)
    {
        var db = new FrogbdContext();
        var currproduct  = new Product
        {
          Title = product.Title,
          Image = product.Image,
          Description = product.Description,
          Cost = product.Cost,
          Count = product.Count,
          CategoryId = product.CategoryId,
          Status = product.Status
        };
        db.Products.Add(currproduct);
        db.SaveChanges();
        return Ok(new { message = "Товар добавлен"});
    }
}