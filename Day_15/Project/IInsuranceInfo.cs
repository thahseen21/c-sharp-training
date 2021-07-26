using System;

namespace Project
{
    interface IInsuranceInfo
    {
        int Id { get; }
        DateTime Validity { get; }
        int CustomerId { get; }
        double PremiumAmount { get; }
    }
}
