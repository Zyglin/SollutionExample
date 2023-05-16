using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public WeatherForecastController()
        {
        }

        /// <summary>
        /// Тут я описываю что делает мой метод
        /// </summary>
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
       
    }
}

/*
Web API представляет способ построения приложения в стиле REST (Representation State Transfer).
REST-архитектура предполагает применение следующих методов или типов запросов HTTP для взаимодействия с сервером:
GET (получение данных)
POST (добавление данных)
PUT (изменение данных)
DELETE (удаление данных)
 */