using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pepeapi.Model;
[ApiController]
[Route("api")]
public class UserController : ControllerBase
{
    [HttpPost("auth/register")]
    public IActionResult Register(User user)
    {
        var db = new FrogbdContext();
        var newUser = new User
        {
            Surname = user.Surname,
            Name = user.Name,
            Patronomic = user.Patronomic,
            Login = user.Login,
            Password = user.Password,
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
    [HttpPut("auth/delete")]
    public IActionResult DeleteUser(User user)
    {
        var db= new FrogbdContext();
        var users = db.Users.FirstOrDefault(u => u.Iduser == user.Iduser);
        if (users == null)
        {
            return BadRequest(new { message = "Пользователь не найден"});
        }
        users.Status = "Удален";
        db.SaveChanges();
        return Ok(new { message = "Пользователь удалён!"});
    }
    [HttpPut("auth/edit")]
    public IActionResult EditUser(User user)
    {
        var db= new FrogbdContext();
        var curr_user = db.Users.FirstOrDefault(u => u.Iduser == user.Iduser);
      
        if (curr_user == null)
        {
            return BadRequest(new { message = "Пользователь не найден"});
        }
            curr_user.Iduser = user.Iduser;
            curr_user.Surname = user.Surname;
            curr_user.Name = user.Name;
            curr_user.Patronomic = user.Patronomic;
            curr_user.Login = user.Login;
            curr_user.Password = user.Password;
        var exlogin = db.Users.FirstOrDefault(u => u.Login == user.Login && u.Iduser != user.Iduser);
        if (exlogin != null)
        {
            return BadRequest(new { message = "Этот логин уже занят"});
        }
            
        db.SaveChanges();
        return Ok(new
        {
            message = "Пользователь обновлен!",
        });
    }
}

