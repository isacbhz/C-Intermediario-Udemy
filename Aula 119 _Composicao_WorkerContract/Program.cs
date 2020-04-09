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
            Console.WriteLine("-----Workes Contract-----");
            Console.Write("Enter department's name: ");
            string departament = Console.ReadLine();

            Console.WriteLine("Enter Worker Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel wl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(departament);
            Worker worker = new Worker(name, baseSalary, wl, dept);

            Console.Write("How many contracts to this worker? ");
            int numContract = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numContract; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string moAndYe = Console.ReadLine();
            string[] dt = moAndYe.Split('/');
            worker.Income(int.Parse(dt[0]), int.Parse(dt[1]));
            Console.WriteLine(worker);
            Console.WriteLine("Income For "+moAndYe+" : "+worker.Income(int.Parse(dt[0]),int.Parse(dt[1])).ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
