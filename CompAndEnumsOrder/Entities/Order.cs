using System;
using CompAndEnumsOrder.Entities.Enums;
using System.Collections.Generic;
using System.Text;


namespace CompAndEnumsOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orderitem { get; set; } = new List<OrderItem>();

        public Order() 
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem orderitem) {
            Orderitem.Add(orderitem); 
        }
        public void RemoveItem(OrderItem orderitem) {
            Orderitem.Remove(orderitem);
        }
        public double Total() {
            return 
        }

    }
}
