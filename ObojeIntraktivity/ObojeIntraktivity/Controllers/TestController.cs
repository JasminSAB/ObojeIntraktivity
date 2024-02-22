using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ObojeIntraktivity.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet(Name = "GetGradovi")]
    public  IActionResult GetGradovi()
    {
        return Ok(new List<string>
        {
            "Ovo je",
            "preko http requesta.. ",
            "lista stringova.."
        });
    }
}