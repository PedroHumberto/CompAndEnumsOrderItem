using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompAndEnumsOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() 
        { 
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double subTotal() {
            return Price * Quantity;
        }


    }
}
