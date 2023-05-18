using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Range(18, 99)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}