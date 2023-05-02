using Lesson15.Models;
using Lesson15.Models.TestClass;
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
            
            var personList = new List<Person>() {
                new Person{ Id = 1,Name = "Artem"},
                new Person{ Id = 2, Name = "Egor"},
                new Person{ Id = 3, Name = "Oleg"},
                new Person{ Id = 4, Name = "Oleg"},

            };


            var usersList = new List<string>
            {
                "Artem",
                "Maksim",
                "Egor",
                "Oleg",
                "Ivan",
                "Maksim",
                "Maksim",
                "Maksim",
                "Maksim",
            };

            var users = db.Users.Include(m => m.Manufacture).ToList();
            //var users1 = db.Users.All(u => u.Id > 2);
            //var personTest = personList.All(p => p.Id > 2);
            //var personTest2 = personList.Any(p => p.Id > 2);
            //var users2 = db.Users.Any(u => u.Name.Equals("asdasdasasdadasd"));
            //var users3 = usersList.Any(u => u.Equals("Ivan"));
            //var users4 = (from u in usersList select u).Any(u => u.Equals("Ivan"));

            //var users5 = usersList.Count();
            //var users6 = personList.First(p => p.Id == 3); //выбирает первый элемент коллекции
            //var users7 = personList.FirstOrDefault(p => p.Name.Equals("Oleg")); //выбирает первый элемент коллекции или возвращает значение по умолчанию
            
            //var users8 = usersList.Single(u=> u.Equals("Maksim")); //выбирает единственный элемент коллекции, если
            //коллекция содержит больше или меньше одного элемента, то генерируется исключение
            //var users9 = usersList.SingleOrDefault(u => u.Equals("Leon")); //выбирает первый элемент коллекции или возвращает значение по умолчанию
            //var users10 = personList.Select(u => new UserViewModel
            //{
            //    Id = u.Id,
            //    Name = u.Name,
            //    ManufactureId = 4
            //}).ToList();
            
            // определяет проекцию выбранных значений
            var users11 = usersList.Where(u => u.Equals("Artem") || u.Equals("Ivan"));//определяет фильтр выборки
            var users12 = personList.OrderBy(u => u.Name);
            var users13 = usersList.OrderByDescending(u => u);//упорядочивает элементы по убыванию
            var users14 = usersList.Skip(2); //пропускает определенное количество элементов. Количество пропускаемых элементов передается в качестве параметра в метод
            //Если необходимо пропустить определенное количество элементов с конца коллекции, то применяется метод SkipLast()
            var users15 = usersList.Take(3);//извлекает определенное число элементов. Количество извлекаемых элементов передается в метод в качестве параметра
            return View(users);
        }
    }
}
// операторы LINQ и методы расширения LINQ
// var phones = from p in db.Phones
// where p.CompanyId == 1
//            select p;

// var phones = db.Phones.Where(p=> p.CompanyId == 1);

//Совмещая оба метода - Take и Skip, мы можем выбрать определенное количество элементов начиная с определенного элемента
