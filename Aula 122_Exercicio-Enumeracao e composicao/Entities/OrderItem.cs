using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_122_Exercicio_Enumeracao_e_composicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public OrderItem() { }
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
