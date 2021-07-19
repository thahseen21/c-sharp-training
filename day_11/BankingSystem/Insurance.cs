using System;
namespace BankManagementSystem
{
    public class Insurance
    {
        public double InsuranceValue;
        public DateTime isActiveFrom;
        public DateTime DueDate;
        public Insurance()
        {
            isActiveFrom = DateTime.Now;
            DueDate = isActiveFrom.AddDays(30);
        }

    }
}