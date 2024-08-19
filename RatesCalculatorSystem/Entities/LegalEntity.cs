namespace RatesCalculatorSystem.Entities
{
    internal class LegalEntity : Taxpayer
    {
        public int Employees { get; set; }


        public LegalEntity() { }

        public LegalEntity(double annualIncome, string name, int employees) : base(annualIncome, name)
        {
            Employees = employees;
        }

        public override double GetTotalRate()
        {
            if (Employees <= 10)
            {
                return AnnualIncome * 0.16;
            }
            return AnnualIncome * 0.14;
        }
    }
}
