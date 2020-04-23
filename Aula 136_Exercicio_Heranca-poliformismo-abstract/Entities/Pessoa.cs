using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities
{
    abstract class Pessoa
    {
        public string Name{get; set; }
        public double AnualIncome { get; set; }
        public Pessoa(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double TaxesCalculation();
    }
}
