using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Product
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = "Currency code must be a 3-letter uppercase code")]
        public string CurrencyCode { get; set; }
    }
}