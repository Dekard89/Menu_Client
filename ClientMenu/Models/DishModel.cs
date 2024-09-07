using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMenu.Models
{
    public class DishModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Image { get; set; } = String.Empty;

        public double Price { get; set; }

        public Category Category { get; set; }

        public List<IngredientDTO>? ExtraIngredients { get; set; }

        public TimeSpan TimeToCook { get; set; }

        public bool IsAvailable { get; set; }

        public int AvailableQuantity { get; set; }

        public string AppendName(string str) => Name += $"\n with {str}";

        public double Appendprice(double price) => Price += price;

    }
}
