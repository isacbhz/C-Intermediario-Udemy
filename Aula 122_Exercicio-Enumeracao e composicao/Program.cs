﻿using System;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities.Enums;
using System.Globalization;

namespace Aula_122_Exercicio_Enumeracao_e_composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dtBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client client = new Client(name, email, dtBirth);
            Order order = new Order(DateTime.Now,status,client);

            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nItems; i++)
            {               
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string proName = Console.ReadLine();
                Console.Write("Product price: ");
                double proPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int proQtd = int.Parse(Console.ReadLine());
                
                Product prd = new Product(proName, proPrice);
                OrderItem ordItem = new OrderItem(proQtd, proPrice, prd);
                order.AddItem(ordItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");           
            Console.WriteLine(order);            
            Console.ReadLine();
        }
    }
}
