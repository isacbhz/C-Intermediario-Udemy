using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities
{
    class PessoaFisica : Pessoa
    {
        public double TaxePercentual { get; set; }
        public double HealthExpenditures { get; set; }
        public override double TaxesCalculation()
        {
            throw new NotImplementedException();
        }
    }
}
