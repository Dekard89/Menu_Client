using ClientMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMenu.DTO
{
    public class DishDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; } = 1;

        public List<int>? IngredientIds { get; set; } = new();

        public DishDto(DishModel model)
        {
            Id = model.Id;

            Name = model.Name;

            Count = 1;

            IngredientIds=model.ExtraIngredients.Select(x=>x.Id).ToList();
        }

        public int AddCout() => Count += 1;
    }
}
