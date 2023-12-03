using AngularASP.NETCore.Server.Data.Models;
using AngularASP.NETCore.Server.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularASP.NETCore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ConversionRequest request)
        {
            decimal value = 0;
            if (string.IsNullOrEmpty(request.Text))
            {
                return BadRequest("The input cannot be empty or null.");
            }
            if (!decimal.TryParse(request.Text, out value))
            {
                return BadRequest("Not a number!");
            }
            else
            {
                value = decimal.Parse(request.Text);
            }
            string convertedValue = Data.Services.Convert.ConvertToWords(value);
            return Ok(convertedValue);
        }
    }
}
