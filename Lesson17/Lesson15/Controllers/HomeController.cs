using Lesson15.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;

namespace Lesson15.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        PersonViewModel[] people;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

             people = new PersonViewModel[]
            {
                    new PersonViewModel(1, "Artem", 84,"Zyg"),
                    new PersonViewModel(2, "Danil", 83,"Zyg"),
                    new PersonViewModel(3, "Yura", 82,"Zyg")
            };
        }

      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View(people);
        }

        [HttpGet]
        public IActionResult Form() => View();

        //[HttpPost]
        //public string Form(string username, string password, int age, string info)
        //{
        //    return $"User Name: {username}   Password: {password}   Age: {age}  Info: {info}";
        //}

        [HttpPost]
        public string Form(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                return $"User Name: {person.Name}   Surname: {person.Surname}   Age: {person.Age}";
            }
            else
            {
                return "Данные не прошли валидацию";
            }
        }

        //Привязка модели или Model binding представляет механизм сопоставления значений из HTTP-запроса с параметрами метода контроллера.
        //При этом параметры могут представлять как простые типы(int, float и т.д.), так и более сложные типы данных, например, объекты классов.
        //Но группа атрибутов позволяет переопределить это поведения, указав один целевой источник для поиска значений:

        //[FromHeader]: данные извлекаются из заголовков запроса

        //[FromQuery]: данные извлекаются из строки запроса

        //[FromRoute]: данные извлекаются из значений маршрута

        //[FromForm]: данные извлекаются из полученных форм

        //[FromBody]: данные извлекаются из тела запроса.Этот атрибут может применяться,
        //    когда в качестве источника данных выступает не форма и не строка запроса, а, скажем, данные отправляются через AJAX

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

   

}

//Одним из ключевых компонентов паттерна MVC являются модели. Ключевая задача моделей - описание структуры и логики используемых данных.
//Все используемые сущности в приложении выделяются в отдельные модели.
//В зависимости от задач и предметной области мы можем выделить различное количество моделей в приложении.
//Все модели оформляются как обычные классы. 