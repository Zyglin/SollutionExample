using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    //Эта модель представляет те объекты, которые будут храниться в базе данных.
}
//Чтобы взаимодействовать с базой данных через EF нам нужен контекст данных(класс, унаследованный от класса Microsoft.EntityFrameworkCore.DbContext).
