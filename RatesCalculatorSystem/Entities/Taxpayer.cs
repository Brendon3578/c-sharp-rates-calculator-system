namespace RatesCalculatorSystem.Entities
{
    internal abstract class Taxpayer
    {

        public double AnnualIncome { get; set; }
        public string Name { get; set; }

        public abstract double GetTotalRate();

        protected Taxpayer()
        {
        }

        protected Taxpayer(double annualIncome, string name)
        {
            AnnualIncome = annualIncome;
            Name = name;
        }
    }
}
