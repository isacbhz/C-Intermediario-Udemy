﻿using System.Globalization;
namespace Aula_130_Polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
        public override string ToString()
        {
            return "Name: " + Name +
                "\nPayment: $" + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
