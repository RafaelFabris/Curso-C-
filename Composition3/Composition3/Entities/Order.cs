using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition3.Entities.Enums;
using System.Collections.Generic;

namespace Composition3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> ListItens { get; set; } = new List<OrderItem>();
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            ListItens.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            ListItens.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0; 
            foreach (OrderItem orderItem in ListItens)
            {
                sum += orderItem.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Order Sumary:");
            s.Append("Order moment:");
            s.AppendLine(Moment.ToString());
            s.Append("Order status:");
            s.AppendLine(Status.ToString());
            s.Append("Client: ");
            s.Append(Client.Name);
            s.Append(" (");
            s.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            s.Append(") - ");
            s.AppendLine(Client.Email);
            s.AppendLine("Order items: ");
            foreach(OrderItem orderItem in ListItens)
            {
                s.AppendLine(orderItem.ToString());
            }
            s.Append("Total Price: $");
            s.AppendLine(Total().ToString());

            return s.ToString();
       }
    }
}
