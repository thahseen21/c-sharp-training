using System;
using System.Collections.Generic;

namespace BankManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IAccountInformation> AccountHolderList = new Dictionary<string, IAccountInformation>();

            var temp = new SavingsAccount();
            temp.SetAccountInformation("Thahseen", 20000);
            temp.NewInsurance();
            temp.CheckRenewalDate();
            AccountHolderList.Add("Thahseen", temp);

            var temp2 = new DematAccount();
            temp2.SetAccountInformation("mohammed", 25000);
            var tempPanNumber = "BYNPD1234D";

            temp2.AvailFreeLocker();

            //Extension Method
            var isValidPan = tempPanNumber.ValidatePanNumber();
            if (isValidPan)
            {
                Console.WriteLine($"Valid PanNumber");
                temp2.SetPanNumber(tempPanNumber);
            }
            else
            {
                Console.WriteLine($"Invalid PanNumber");
            }
            AccountHolderList.Add("mohammed", temp2);

            Console.WriteLine($"----------------------------------------------------");

            foreach (var item in AccountHolderList)
            {
                var customerDetail = (IAccountInformation)item.Value;
                customerDetail.DisplayUserInformation();
                Console.WriteLine($"----------------------------------------------------");
            }

        }
    }
}