using System;
using Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities;
using System.Collections.Generic;
using Aula_136_Exercicio_Heranca_poliformismo_abstract.Entities.Enums;
using System.Globalization;

namespace Aula_136_Exercicio_Heranca_poliformismo_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int nPayers = int.Parse(Console.ReadLine());
            List<Pessoa> pessoaList = new List<Pessoa>();
            for (int i = 1; i <= nPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company? ");
                TypeApplicationTaxe type = Enum.Parse<TypeApplicationTaxe>(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == TypeApplicationTaxe.Individual)
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoaList.Add(new PessoaFisica(healthExp, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nEmploy = int.Parse(Console.ReadLine());
                    pessoaList.Add(new PessoaJuridica(nEmploy, name, anualIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.00;
            foreach (Pessoa p in pessoaList)
            {
                Console.WriteLine(p.ToString()); ;
                totalTaxes += p.TaxesCalculation();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $"+totalTaxes.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
