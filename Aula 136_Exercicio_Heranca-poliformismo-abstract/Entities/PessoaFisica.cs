using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities
{
    class PessoaFisica : Pessoa
    {
        public double PercentualTaxe { get; set; }
        public double HealthExpenditures { get; set; }
        public PessoaFisica(double percentualTaxe, double healthExpenditures, string name, double anualIncome) : base(name,anualIncome)
        {
            PercentualTaxe = percentualTaxe;
            HealthExpenditures = healthExpenditures;
        }
        public override double TaxesCalculation()
        {
            double TotalTaxe = AnualIncome;
            if (AnualIncome < 20000.00)
            {
                Console.Write("Health expedintures: ");
                double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (healthExp > 0.00)
                {                    
                    TotalTaxe *= 0.25 + (HealthTaxes(healthExp));
                }
                else
                {
                    TotalTaxe *= 0.15;
                }
            }
            return TotalTaxe;
        }
        public double HealthTaxes(double healthExp)
        {
            double calc = 0.00;
            calc = (healthExp * 0.25);
            return calc;
        }
    }
}
