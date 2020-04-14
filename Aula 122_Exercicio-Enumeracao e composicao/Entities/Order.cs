using System;
using System.Collections.Generic;
using System.Text;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities.Enums;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities;
using System.Globalization;

namespace Aula_122_Exercicio_Enumeracao_e_composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double total(double total)
        {
            return total +=total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);sb.Append(" , $");
                sb.Append(item.Price.ToString());sb.Append(" , Quantitty: ");sb.Append(item.Quantity.ToString());
                sb.Append(" , Subtotal: $");sb.Append(item.subTotal().ToString("F2",CultureInfo.InvariantCulture));
                sb.AppendLine("");
                total(item.subTotal());
            }
            Console.WriteLine("Total price: ");
            return sb.ToString();
        }
    }
}
