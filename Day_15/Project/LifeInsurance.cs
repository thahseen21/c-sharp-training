using System;

namespace Project
{
    class LifeInsurance : IInsuranceInfo
    {
        public int Id { get; private set; }
        public DateTime Validity { get; private set; }
        public int CustomerId { get; private set; }
        public double PremiumAmount { get; private set; }
        private string NomineeName { get; set; }
        private DateTime MaturityDate { get; set; }
        public LifeInsurance() { }
        public LifeInsurance(int id, DateTime validity, int customerId, double premiumAmount, string nomineeName)
        {
            this.Id = id;
            this.Validity = validity;
            this.CustomerId = customerId;
            this.PremiumAmount = premiumAmount;
            this.NomineeName = nomineeName;
        }
        public void CalcMaturityDate()
        {
            this.MaturityDate = DateTime.Now.AddYears(10);
        }

    }
}
