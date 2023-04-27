using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class PersonViewModel
    {
        [Required]
        public int Id { get; set; } = 1;
        [Required]
        [MinLength(12)]
        [MaxLength(23)]
        public string Name { get; set; } = "";
        [Required]
        public int Age { get; set; }
        [MaxLength(23)]
        public string Surname { get; set; } = "";
        public PersonViewModel()
        {
        }
        public PersonViewModel(int id, string name, int age, string surname)
        {
            Id = id;
            Name = name;
            Age = age;
            Surname = surname;
        }
    }
}

//Важную роль в ASP.NET Core MVC играет валидация входных данных. Валидация позволяет проверить входные данные на наличие неправильных,
//    корректных значений и должным образом обработать эти значения. Валидация модели в ASP.NET Core MVC базируется на общем механизме валидации, который имеется в .NET,
//    однако ASP.NET Core MVC добавляет некоторую дополнительную инфраструктуру, которая облегчает процесс валидации.