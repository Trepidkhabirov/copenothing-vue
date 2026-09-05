using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pepeapi.Model;
[ApiController]
[Route("api")]
public class UserController : ControllerBase
{
    [HttpPost("auth/register")]
    public IActionResult Register(User users)
    {
        var db = new FrogbdContext();
        var newUser = new User
        {
            Surname = users.Surname,
            Name = users.Name,
            Patronomic = users.Patronomic,
            Login = users.Login,
            Password = users.Password,
            Status = "Активен",
            Role = "User"
        };
        db.Users.Add(newUser);
        db.SaveChanges();
        return Ok(new
        {
            message = "Регистрация прошла успешна!",
            userId = newUser.Iduser,
            name = newUser.Name,
            surname = newUser.Surname,
            patronomic = newUser.Patronomic,
            login = newUser.Login,
            password = newUser.Password,
            Status = newUser.Status,
            Role = newUser.Role
        });
    }
    [HttpGet("auth/login")]
    public IActionResult Authorization(string login, string password)
    {
        var db= new FrogbdContext();
        var users = db.Users.FromSqlRaw($"select * from Users where login = '{login}' and password = '{password}'").ToList();
        if (users.Count() == 0)
        {
            return Unauthorized(new { message = "Неверный логин или пароль"});
        }
        else
        {
            foreach (var user in users)
            {

            return Ok(new { message = "Вы успешно авторизованы!",
                 userId = user.Iduser,
            name = user.Name,
            surname = user.Surname,
            patronomic = user.Patronomic,
            login = user.Login,
            password = user.Password,
            Status = user.Status,
            Role = user.Role
            });
                
            }
            return Unauthorized( new { message = "Ошибка авторизации"});
        }
    }
}

