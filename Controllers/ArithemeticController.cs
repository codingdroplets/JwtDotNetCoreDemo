using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArithemeticController : ControllerBase
    {
        [Authorize]
        [HttpPost]
        [Route("SumValues")]
        public IActionResult Sum([FromQuery(Name = "Value1")] int value1, [FromQuery(Name = "Value2")] int value2)
        {
            var result = value1 + value2;
            return Ok(result);
        }
    }
}
