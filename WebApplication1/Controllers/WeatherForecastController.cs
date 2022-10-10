using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        private string mensaje(int numero)
        {
            string mensaje = "";
            if (numero % 3 == 0)
            {
                return mensaje = "HELP";
            }

            if (numero % 5 == 0)
            {
                return mensaje = "ME";
            }

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                return mensaje = "HELPME";
            }
            return "";
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            int numero2 = 1;            

            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new WeatherForecast
            {
                Numero = numero2++,
                Summary = mensaje(numero2) 

            }).ToArray();
            
        }
    }
}
