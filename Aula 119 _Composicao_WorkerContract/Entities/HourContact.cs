﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_119__Composicao_WorkerContract.Entities
{
    class HourContact
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContact() { }
        public HourContact(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
