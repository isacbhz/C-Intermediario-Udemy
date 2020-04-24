using System;
using System.Collections.Generic;
using System.Text;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities.Enums;
using System.Globalization;
    
namespace Aula_122_Exercicio_Enumeracao_e_composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public double total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy")+")"+" - "+Client.Email);
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name+", $"+item.Price.ToString("F2",CultureInfo.InvariantCulture)+
                    ", Quantity: "+item.Quantity.ToString()+", Subtotal: $"+item.subTotal().ToString("F2",CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
