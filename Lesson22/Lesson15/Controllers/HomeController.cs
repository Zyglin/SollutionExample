using Lesson15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;

namespace Lesson15.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            db = context;
        }

      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var manufactures = db.Manufactures.ToList();
            IEnumerable<SelectListItem> manufactureItems = manufactures.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name
            });
            ViewBag.Manufacture = manufactureItems;

            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            var manufacture = db.Manufactures.FirstOrDefault(m => m.Id == model.ManufactureId);
            var user = new User
            {
                Name = model.Name,
                LastName = model.LastName,
                Age = model.Age,
                Address = model.Address,
                Manufacture = manufacture,
            };

            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                User user = db.Users.FirstOrDefault(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                User user = db.Users.FirstOrDefault(p => p.Id == id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return RedirectToAction("Privacy");
                }
            }
            return NotFound();
        }

        public IActionResult Privacy()
        {
            //var users = db.Users.ToList();
            var users = db.Users.Include(m => m.Manufacture).ToList();
            return View(users);
        }
    }   
}
//Entity Framework - ORM-решение, которое позволяет автоматически связать обычные классы языка C# с таблицами в базе данных.
//Entity Framework Core понадобится для  работы с СУБД MS SQL Server
//для работы Entity Framework необходим пакет Microsoft.EntityFrameworkCore.SqlServer.