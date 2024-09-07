using ClientMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClientMenu.DTO
{
    public record DishRequest
    {
        public DishRequest()
        {
            Category = Category.Basic;

            Search=String.Empty;
        }
        public Category Category { get; set; }

        public string Search { get; set; } = String.Empty;
        public string ToRequestString() => $"request?Category={Category.ToString()}&Search={Search}";
    }
    
}
