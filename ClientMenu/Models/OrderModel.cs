using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMenu.Models
{
    public class OrderModel
    {
        public int TableNumber { get; set; }

        public List<DishModel> ListOrder { get; set; } = new();

        public DateTime ReadyTime
        {
            get => ReadyTime;

            set =>ReadyTime= DateTime.Now + ListOrder.Max(x => x.TimeToCook);
        }
    }
}
