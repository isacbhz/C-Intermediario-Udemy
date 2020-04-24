﻿using System;
using System.Collections.Generic;
using System.Text;

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
            double totalTaxe = AnualIncome;
            if (EmployeesQuant > 10)
            {
                totalTaxe *= 0.14;
            }
            else
            {
                totalTaxe *= 0.16;
            }
            return totalTaxe;
        }
    }
}
