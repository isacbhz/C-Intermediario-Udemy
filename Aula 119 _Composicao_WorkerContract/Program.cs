using System;
using System.Globalization;
using Aula_119__Composicao_WorkerContract.Entities;
using Aula_119__Composicao_WorkerContract.Entities.Enums;
namespace Aula_119__Composicao_WorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####  Worker Contracts #####");
            Console.Write("Enter department's name: ");
            string dep = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double bSal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dpt = new Department(dep);
            Worker worker = new Worker(name, level, bSal, dpt);

            Console.Write("How many contracts to this worker? ");
            int nCont = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nCont; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContact contract = new HourContact(date, value, duration);
                worker.AddContract(contract);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string moAndYe = Console.ReadLine();
            int month = int.Parse(moAndYe.Substring(0, 2));
            int year = int.Parse(moAndYe.Substring(3));
            Console.WriteLine(worker);
            Console.WriteLine("Income for "+moAndYe+" : $"+worker.Income(month,year).ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
