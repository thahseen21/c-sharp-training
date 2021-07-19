using System;
namespace BankManagementSystem
{
    //we can declare partial for interface,class and structure
    public interface IAccountInformation
    {
        string Name { get; }
        DateTime DOB { get; }
        int AccountNumber { get; }
        double AccountBalance { get; }
        DateTime ActiveFromDate { get; }
        bool IsAccountActive { get; }
        void SetAccountInformation(string Name, double amount);
        void DisplayUserInformation();
        void EnableAccount();
        void DisableAccount();
    }
}