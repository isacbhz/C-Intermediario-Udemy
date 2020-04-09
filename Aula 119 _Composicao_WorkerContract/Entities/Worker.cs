using System.Collections.Generic;
using Aula_119__Composicao_WorkerContract.Entities.Enums;

namespace Aula_119__Composicao_WorkerContract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }        
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker() { }
        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;           
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
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    sum +=contract.totalValue();
                }               
            }
            return sum;
        }
        public override string ToString()
        {
            return "Name: "+Name+
                "\nDepartment: "+Department.Name; 
        }
    }
}
