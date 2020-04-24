using System;
using System.Globalization;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities;
using Aula_122_Exercicio_Enumeracao_e_composicao.Entities.Enums;

namespace Aula_122_Exercicio_Enumeracao_e_composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bDate = DateTime.Parse(Console.ReadLine());            
            Client client = new Client(name, email, bDate);           
            
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status,client);

            Console.Write("How many items to this order? ");
            int nItem = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nItem; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prdName = Console.ReadLine();
                Console.Write("Product price: ");
                double prdPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                
                Product product = new Product(prdName, prdPrice);
                OrderItem orderItem = new OrderItem(qtd, prdPrice, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");            
            Console.WriteLine(order);
            
            Console.Write("Total price: $"+order.total().ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
