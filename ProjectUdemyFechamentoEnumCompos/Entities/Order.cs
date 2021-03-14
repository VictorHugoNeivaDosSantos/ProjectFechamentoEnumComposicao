using System;
using System.Collections.Generic;
using System.Text;
using ProjectUdemyFechamentoEnumCompos.Entities;
using ProjectUdemyFechamentoEnumCompos.Entities.Enums;
using System.Globalization;

namespace ProjectUdemyFechamentoEnumCompos.Entities
{
    class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orderitem { get; set; } = new List<OrderItem>();
        public Client cliente { get; set; } = new Client();

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
          
            this.cliente = cliente;
        }

        public Order()
        {
        }

        public void AddItem(OrderItem item)
        {
            Orderitem.Add(item);

        }

        public void RemoveItem(OrderItem item)
        {
            Orderitem.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (OrderItem item in Orderitem)
            {

                soma += item.SubTotal();

            }

            return soma;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + cliente);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Orderitem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
