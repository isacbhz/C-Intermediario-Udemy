using System;
using Diversos.Entities;


namespace Diversos
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "joao", 500.0);
            Account acc2 = new SavingsAccount(1002, "maria", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.ReadLine();
        }
    }
}
