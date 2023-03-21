using Lesson15.Dto;
using Lesson15.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Reflection.PortableExecutable;
using static System.Net.WebRequestMethods;

namespace Lesson15.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //ViewData["Имя"] = значение
            //ViewData["Message"] = "Hello all I'm a ViewData Message";
            //ViewData["Number"] = 12;
            //ViewData["Kostya"] = true;
            //ViewBag.имя = значение
            //ViewBag.Message = "Hello all I'm a ViewBag Message";
            //ViewBag.Students = new string [] { "Danil", "Yura", "Evgeniy" };
            var cars = new string[] {
                "https://mobimg.b-cdn.net/v3/fetch/a4/a48610bf58b05618a5470c6da6ecde49.jpeg",
                "https://www.ixbt.com/img/n1/news/2020/7/4/Tesla-wrap-hero_large.jpg",
                "https://www.ixbt.com/img/n1/news/2022/7/2/JiDU-ROBO-1-Baidu-First-Car-Business_large.png" };
            return View(cars);
            //Представления, для которых определена модель называют строго типизированными
        }

        [HttpGet]
        public IActionResult Form() => View();

        [HttpPost]
        public string Form(string username, string password, int age, string info)
        {
            return $"User Name: {username}   Password: {password}   Age: {age}  Info: {info}";
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    //При использовании контроллеров существуют некоторые условности.
    //Прежде всего обычно в проекте контроллеры помещаются в каталог Controllers.
    //В ASP.NET Core MVC контроллер представляет обычный класс на языке C#, который обычно наследуется от абстрактного базового класса Microsoft.AspNetCore.Mvc.Controller и который
    //, как и любой класс на языке C#, может иметь поля, свойства, методы
    //. Согласно соглашениям об именовании названия контроллеров обычно оканчиваются на суффикс "Controller",
    //остальная же часть до этого суффикса считается именем контроллера, например, HomeController.
    //Но есть также и обязательные условности, которые предъявляются к контроллерам. Класс контроллера должен удовлетворять как минимум одному из следующих условий:
    //Класс контроллера имеет суффикс "Controller"
    //Класс контроллера наследуется от класса, который имеет суффикс "Controller"

}