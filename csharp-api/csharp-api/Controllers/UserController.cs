using csharp_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_api.Controllers;
[ApiController]
[Route("")]
public class UserController : ControllerBase
{
    [HttpGet("user/{id}")]
    public ResponseUser Get(string id)
    {
        Console.WriteLine(id);
        return new Bl().UserGetBl(new RequestUser(){Id = id});
    }
    
    [HttpPost("user")]
    public ResponseUser Post(RequestUser user)
    {
        Console.WriteLine("test");
        return new Bl().UserPostBl(user);
    }
    
    [HttpPut("user/{id}")]
    public ResponseUser Put(string id, RequestUser user)
    {
        Console.WriteLine(id);
        return new Bl().UserPutBl(user);
    }
}