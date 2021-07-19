using System;

namespace BankManagementSystem
{
    class SavingsAccount : IAccountInformation, IBenefits
    {
        public string Name { get; private set; }
        public DateTime DOB { get; private set; }
        public int AccountNumber { get; private set; }
        public double AccountBalance { get; private set; }
        public DateTime ActiveFromDate { get; private set; }
        public bool IsAccountActive { get; private set; } = true;
        private bool IsInsured = false;
        private Insurance Insure;
        public void SetAccountInformation(string name, double amount)
        {
            this.Name = name;
            this.ActiveFromDate = DateTime.Now;
            this.AccountNumber = RandomNumber.GenerateRandomNumber(1, 999999);
            this.AccountBalance = amount;
        }
        public void DisplayUserInformation()
        {
            var accountStatus = this.IsAccountActive ? "Active" : "Freezed";
            var insuranceStatus = this.IsInsured ? "Insured" : "Not Insured";
            Console.WriteLine($"Account name:{this.Name}\nAccount Balance:{this.AccountBalance}\nOpening Date: {this.ActiveFromDate}\nAccount Status:{accountStatus}\nInsurance:{insuranceStatus}");
        }
        public void EnableAccount()
        {
            this.IsAccountActive = false;
            Console.WriteLine($"Account is disabled...");
        }
        public void DisableAccount()
        {
            this.IsAccountActive = true;
            Console.WriteLine($"Account is Enabled...");
        }
        public void NewInsurance()
        {
            this.Insure = new Insurance();
            this.IsInsured = true;
            Console.WriteLine($"Created a new insurance.....Enjoy Life");
        }
        public void CheckRenewalDate()
        {
            if (this.IsInsured)
            {
                this.Insure.GetDueDays();
            }
        }
        public void AvailFreeDemandDraft()
        {
            Console.WriteLine($"Demand Draft is produced...");
        }
        public void AvailFreeLocker()
        {
            Console.WriteLine($"Free Locker is provided...");
        }
    }
}
