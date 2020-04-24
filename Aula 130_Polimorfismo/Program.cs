using System;
using System.Globalization;
using System.Collections.Generic;
using Aula_130_Polimorfismo.Entities;

namespace Aula_130_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int nEmp = int.Parse(Console.ReadLine());
            List<Employee> emp = new List<Employee>();

            for (int i = 1; i <= nEmp; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? : ");
                string outSou = Console.ReadLine();
                if (outSou == "y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value Per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Addiotnal charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee emplo = new OutSourceEmployee(name, hours, valuePerHour, addCharge);
                    emp.Add(emplo);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value Per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                    Employee emplo = new Employee(name, hours, valuePerHour);
                    emp.Add(emplo);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee item in emp)
            {
                Console.WriteLine(item.Name+" - $ "+item.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
