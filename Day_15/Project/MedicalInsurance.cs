using System;

namespace Project
{
    class MedicalInsurance : IInsuranceInfo
    {
        public int Id { get; private set; }
        public DateTime Validity { get; private set; }
        public int CustomerId { get; private set; }
        public double PremiumAmount { get; private set; }
        public int AppointmentsCompleted { get; private set; }

        public MedicalInsurance() { }
        public MedicalInsurance(int id, DateTime validity, int customerId, double premiumAmount)
        {
            this.Id = id;
            this.Validity = validity;
            this.CustomerId = customerId;
            this.PremiumAmount = premiumAmount;
        }

    }
}
