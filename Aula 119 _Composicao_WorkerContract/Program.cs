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
            Console.WriteLine("##### Worker Contract #####");
            Console.Write("Enter department's name: ");
            string depart = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(depart);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int numCont = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numCont; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: " );
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string moAndYe = Console.ReadLine();
            string[] dt = moAndYe.Split('/');
            Console.WriteLine(worker);
            Console.Write("Income for "+moAndYe+" : "+worker.Income(int.Parse(dt[0]),int.Parse(dt[1])).ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
