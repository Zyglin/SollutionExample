using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using UnitTESTS.Models;

namespace UnitTESTS.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public double Sum(double first, double second )
        //{
        //    return first + second;
        //}

        //public User GetUser(int id, int age, string name)
        //{
        //    if (age > 20)
        //    {
        //        return new User() { Id = id, Age = age, Name = name };
        //    }
        //    else
        //    {
        //        return new User() { Id = 0, Age = 0, Name = "Default" };
        //    }
        //}

        public IEnumerable<Car> GetCarsInfos()
        {
            return _repository.GetCars();
        }
    }

    public interface IRepository
    {
        IEnumerable<Car> GetCars();
    }

    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }

        public Car()
        {

        }
        public Car(int id, int year, string name)
        {
            Id = id;
            Year = year;
            Name = name;
        }
    }
}