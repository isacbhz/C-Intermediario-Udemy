using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities
{
    class PessoaFisica : Pessoa
    {
        public double HealthExpenditures { get; set; }
        public PessoaFisica(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double TaxesCalculation()
        {
            double totalTaxe = 0.00;
            if (AnualIncome <= 20000.00)
            {
                totalTaxe = (AnualIncome * 0.15) - (HealthTaxes(HealthExpenditures));
            }
            else
            {
                totalTaxe = (AnualIncome * 0.25) - (HealthTaxes(HealthExpenditures));
            }
            return totalTaxe;
        }
        public double HealthTaxes(double healthExp)
        {
            double calc = 0.00;
            calc = (healthExp * 0.50);
            return calc;
        }
        public override string ToString()
        {
            return Name + " $" + TaxesCalculation().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
