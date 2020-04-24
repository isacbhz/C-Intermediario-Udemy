using System.Globalization;

namespace Aula_130_Polimorfismo.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutSourceEmployee() { }
        public OutSourceEmployee(string name, int hours, double valuePerHour, double addiotnalcharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = addiotnalcharge;
        }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
        public override string ToString()
        {
            return "Name: "+Name+
                "\nPayment: $"+Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
