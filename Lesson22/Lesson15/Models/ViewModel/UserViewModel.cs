using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int ManufactureId { get; set; }
    }
    
}
