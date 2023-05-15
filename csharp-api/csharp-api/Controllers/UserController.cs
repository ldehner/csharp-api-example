using csharp_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_api.Controllers;

public class UserController : Controller
{
    [HttpGet(Name = "user")]
    public IEnumerable<ResponseUser> Get()
    {
        return new ResponseUser();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}