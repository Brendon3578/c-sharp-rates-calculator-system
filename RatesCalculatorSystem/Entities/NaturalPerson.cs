namespace RatesCalculatorSystem.Entities
{
    internal class NaturalPerson : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson() { }

        public NaturalPerson(double annualIncome, string name, double healthExpenditures) : base(annualIncome, name)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double GetTotalRate()
        {
            if (AnnualIncome < 20000)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }

            return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }

    }
}
