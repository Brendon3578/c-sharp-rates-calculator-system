using RatesCalculatorSystem.Entities;
using System.Globalization;

namespace RatesCalculatorSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int quantity = int.Parse(Console.ReadLine());
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"\nTax payer #{i + 1} data:");

                Console.Write($"Individual or company (i/c)? ");
                char taxpayerType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (taxpayerType == 'c')
                {
                    Console.Write("Numbers off employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    LegalEntity company = new LegalEntity(anualIncome, name, employees);
                    taxpayers.Add(company);
                }
                else if (taxpayerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    NaturalPerson indiviual = new NaturalPerson(anualIncome, name, healthExpenditures);

                    taxpayers.Add(indiviual);
                }
            }


            Console.WriteLine("\n TAXES PAID");
            double totalRates = 0.0;
            foreach (var tp in taxpayers)
            {
                totalRates += tp.GetTotalRate();
                Console.WriteLine($"{tp.Name} $ {tp.GetTotalRate():f2}");
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalRates:f2}");
        }
    }
}
