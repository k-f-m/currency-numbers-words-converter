using AngularASP.NETCore.Server.Data.Models;
using AngularASP.NETCore.Server.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularASP.NETCore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TranslationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] TranslationRequest request)
        {
            string translatedValue = Translate.ConvertCurrencyToWords(text: request.Text); // Replace with your translation logic
            return Ok(translatedValue);
        }
    }
}
