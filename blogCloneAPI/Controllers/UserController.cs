using Microsoft.AspNetCore.Mvc;
using blogCloneAPI.Models;  
namespace blogCloneAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            //login logic here
            return Ok("Logged in");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            //  logout logic here
            return Ok("Logged out");
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            //  registration logic here
            return Ok("Registered");
        }
    }
}