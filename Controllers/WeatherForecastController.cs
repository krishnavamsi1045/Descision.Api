using Microsoft.AspNetCore.Mvc;

namespace Descision.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("get")]
      public async Task<IActionResult> Desision([FromRoute] int value)
        {
            var result = value == 20 ? 20 : 35;

            return Ok(new { Message = "succesfull", data = result });
        }
        [HttpGet("hai")]
        public async Task<IActionResult> Sayhai()
        {
            return Ok(new { Message = "hai buddy" });
        }
    }
}
