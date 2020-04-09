using System.Collections.Generic;
using Aula_119__Composicao_WorkerContract.Entities.Enums;

namespace Aula_119__Composicao_WorkerContract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Department Department { get; set; }

        public Worker()
        {

        }
        public Worker(string name, double baseSalary, WorkerLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int month, int year)
        {
            double sum = BaseSalary;
            foreach (HourContract item in Contracts)
            {
                if (item.Date.Year == year && item.Date.Month == month)
                {
                    sum += item.totalValue();
                }
            }
            return sum;
        }
        public override string ToString()
        {
            return "Name: "+Name+
                "\nDepartament: "+Department.Name; 
        }
    }
}
