using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    internal class Cart
    {
        private List<MenuItem> menuItemList = new List<MenuItem>();
        private double total {  get; set; }

        public Cart() 
        {
            total = this.total;
        }


    }
}
