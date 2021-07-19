using System;

namespace BankManagementSystem
{
    class DematAccount : IAccountInformation, IDematBenefits
    {
        public string Name { get; private set; }
        public DateTime DOB { get; private set; }
        public int AccountNumber { get; private set; }
        public double AccountBalance { get; private set; }
        public DateTime ActiveFromDate { get; private set; }
        public bool IsAccountActive { get; private set; } = true;
        public string PanNumber { get; private set; }
        public float CreditScore { get; set; }
        public void SetAccountInformation(string name, double amount)
        {
            this.Name = name;
            this.ActiveFromDate = DateTime.Now;
            this.AccountNumber = RandomNumber.GenerateRandomNumber(1, 999999);
            this.AccountBalance = amount;
        }
        public void SetPanNumber(string panNumber)
        {
            this.PanNumber = panNumber;
        }
        public void DisplayUserInformation()
        {
            var accountStatus = this.IsAccountActive ? "Active" : "Freezed";
            Console.WriteLine($"Account name:{this.Name}\nAccount Balance:{this.AccountBalance}\nOpening Date: {this.ActiveFromDate}\nAccount Status:{accountStatus}\nPan Number :{this.PanNumber}");
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
        public void AvailFreeDemandDraft()
        {
            Console.WriteLine($"Demand Draft is produced...");
        }
        public void AvailFreeLocker()
        {
            Console.WriteLine($"Free Locker is provided...");
        }
        public void AvailFreeCreditScoreCheck()
        {
            Console.WriteLine($"Your Credit Score is {CreditScore}");
        }
        public void GetDailyStockUpdates()
        {
            Console.WriteLine($"Your Stock update");
        }
    }
}
