using HelloWorld.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CalcController : ControllerBase
{
    // GET: api/<CalcController>
    [HttpGet]
    public int Get(int number)
    {
        var calcService = new CalcService();

        var result = calcService.Pow(number);

        return result;
    }
}
