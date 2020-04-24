using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int EmployeesQuant { get; set; }

        public PessoaJuridica(int employeesQuant, string name, double anualIncome):base(name,anualIncome)
        {
            EmployeesQuant = employeesQuant;
        }
        public override double TaxesCalculation()
        {
            double totalTaxe = 0.00;
            if (EmployeesQuant > 10)
            {
                totalTaxe = AnualIncome * 0.14;
            }
            else
            {
                totalTaxe = AnualIncome * 0.16;
            }
            return totalTaxe;
        }
        public override string ToString()
        {
            return Name + " $" + TaxesCalculation().ToString("F2", CultureInfo.InvariantCulture); ; 
        }
    }
}
