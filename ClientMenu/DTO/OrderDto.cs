using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMenu.DTO
{
    public class OrderDto
    {
        public int TableNumber { get; set; }

        public List<DishDto> DishDtos { get; set; }

        public DishDto GetDish(int id) => DishDtos.FirstOrDefault(x => x.Id == id);
    }
}
