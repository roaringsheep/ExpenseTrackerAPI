using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public string Get(string? name) {
        if(name != null)
        {
            return $"Hello {name}!";
        }
        else 
        {
            return "Hello World!";
        }
    }
}