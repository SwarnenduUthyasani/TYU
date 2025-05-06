using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        public List<MenuItem> menuItemList { get; set; } = new List<MenuItem>();
        public double total { get; set; }

        public Cart(List<MenuItem> menuItemList, double total)
        {
            this.menuItemList = menuItemList;
            this.total = total;
        }

        public Cart()
        {
            //Console.WriteLine("Running Cart Cons");
        }
    }
}
