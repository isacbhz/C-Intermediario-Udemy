using System;
using System.Globalization;
using Aula_145_Exercicios_TryCatch.Entities;

namespace Aula_145_Exercicios_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int accuNum = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(accuNum, holder, balance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.WithDraw(amount);
                Console.Write("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }
        }
    }
}
