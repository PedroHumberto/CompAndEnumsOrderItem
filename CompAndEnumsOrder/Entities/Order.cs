using System;
using CompAndEnumsOrder.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using CompAndEnumsOrder.Entities;


namespace CompAndEnumsOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() 
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client, List<OrderItem> items)
        {
            Moment = moment;
            Status = status;
            Client = client;
            Items = items;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item); 
        }
        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }
        public double Total() {
            // pensar em um foreach
            double sum = 0.0;
            foreach (OrderItem item in Items) 
            {
                sum += item.subTotal();
            }
            return sum;
        }




    }
}
