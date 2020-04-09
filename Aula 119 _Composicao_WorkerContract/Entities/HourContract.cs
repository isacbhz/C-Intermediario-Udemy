using System;

namespace Aula_119__Composicao_WorkerContract.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract() { }
        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }
        public double totalValue()
        {
            return ValuePerHour * Hour;
        }
    }
}
