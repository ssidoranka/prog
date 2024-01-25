using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public IActionResult Prod([FromBody] DwaArgumentyRequest request)
        {
            if (request == null)
            {
                return BadRequest("Nieprawidłowe dane wejściowe");
            }

            // Sprawdź, czy oba argumenty zostały przekazane 
            if (!request.Argument1.HasValue || !request.Argument2.HasValue)
            {
                return BadRequest("Oba argumenty są wymagane");
            }

            // Sprawdź, czy drugi argument nie jest równy zero (dzielenie przez zero) 
            if (request.Argument2.Value == 0)
            {
                return BadRequest("Nie można dzielić przez zero");
            }

            // Oblicz iloraz i zwróć wynik 
            double iloraz = request.Argument1.Value / request.Argument2.Value;
            return Ok(iloraz);
        }
        [HttpPost]
        public IActionResult Qote([FromBody] DwaArgumentyRequest request)
        {
            if (request == null)
            {
                return BadRequest("Nieprawidłowe dane wejściowe");
            }

            // Sprawdź, czy oba argumenty zostały przekazane 
            if (!request.Argument1.HasValue || !request.Argument2.HasValue)
            {
                return BadRequest("Oba argumenty są wymagane");
            }

            // Sprawdź, czy drugi argument nie jest równy zero (dzielenie przez zero) 
            if (request.Argument2.Value == 0)
            {
                return BadRequest("Nie można dzielić przez zero");
            }

            // Oblicz iloraz i zwróć wynik 
            double iloraz = request.Argument1.Value / request.Argument2.Value;
            return Ok(iloraz);
        }
        [HttpGet]
        public IActionResult GetSummary(int index)
        {
                       
                if (index >= 0)
                {
                    string summary = Summaries[index % Summaries.Length]; return Ok(summary);
                }
                else
                {
                    return NotFound("Indeks poza zakresem listy Summaries");
                }
            }

        }

   

    public class DwaArgumentyRequest
    {
        public double? Argument1 { get; set; }
        public double? Argument2 { get; set; }
    }

}

