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

//������ ���� � ASP.NET Core MVC ������ ��������� ������� ������. ��������� ��������� ��������� ������� ������ �� ������� ������������,
//    ���������� �������� � ������� ������� ���������� ��� ��������. ��������� ������ � ASP.NET Core MVC ���������� �� ����� ��������� ���������, ������� ������� � .NET,
//    ������ ASP.NET Core MVC ��������� ��������� �������������� ��������������, ������� ��������� ������� ���������.