using System;
using System.Collections.Generic;
using System.Text;
using Aula_119__Composicao_WorkerContract.Entities.Enums;
using Aula_119__Composicao_WorkerContract.Entities;

namespace Aula_119__Composicao_WorkerContract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContact> Contracts { get; set; } = new List<HourContact>();

        public Worker() { }
        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContact contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContact contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int month, int year)
        {
            double sum = BaseSalary;
            foreach (HourContact contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name : " + Name);
            sb.AppendLine("Department: " + Department.Name);            
            return sb.ToString();
        }
    }
}
