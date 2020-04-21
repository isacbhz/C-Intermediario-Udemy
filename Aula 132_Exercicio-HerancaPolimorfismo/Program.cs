using System;
using System.Collections.Generic;
using Aula_132_Exercicio_HerancaPolimorfismo.Entities;
using System.Globalization;

namespace Aula_132_Exercicio_HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numner of products: ");
            int nPrd = int.Parse(Console.ReadLine());
            List<Product> product = new List<Product>();

            for (int i = 1; i <= nPrd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);               
                switch (type)
                {                    
                    case 'i':
                        Console.Write("Customs fee: ");
                        double cusFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        product.Add(new ImportedProduct(cusFee, name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        product.Add(new UsedProduct(date, name, price));
                        break;                    
                    default:
                        product.Add(new Product(name, price));
                        break;
                }               
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in product)
            {
                Console.WriteLine(p.PriceTag());
            }
            Console.ReadLine();
        }
    }
}
