using OnlinePizzaWebApplication.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlinePizzaWebApplication.ViewModels
{
    public class SearchPizzasViewModel
    {
        [Required]
        [DisplayName("Search")]
        public string SearchText { get; set; }
        public IEnumerable<Pizzas> PizzaList { get; set; }

    }
}
