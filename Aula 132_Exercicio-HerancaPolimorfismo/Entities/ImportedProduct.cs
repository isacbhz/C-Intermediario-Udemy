using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula_132_Exercicio_HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(double customFee, string name, double price) : base(name,price)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return CustomFee + Price;
        }
        public override string PriceTag()
        {
            return Name + " $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
                " (Customs fee: $" + CustomFee.ToString("F2", CultureInfo.InvariantCulture)+")";
        }
    }
}
