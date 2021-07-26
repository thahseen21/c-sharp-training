using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        public static List<ICustomerInfo> CustomerList = new List<ICustomerInfo>();
        static void Main(string[] args)
        {
            var obj = new CustomerInfo(21, "Mohammed Thahseen", 21, "O+");
            var customerIdRef = 1;

            // obj.DisplayInfo();

            // obj.NewLifeInsurance(21000);
            // obj.NewMedicalInsurance(20000);
            // obj.NewMedicalInsurance(20000);

            CustomerList.Add(obj);
            CustomerList.Add(new CustomerInfo(41, "Peter", 12, "b+"));
            CustomerList.Add(new CustomerInfo(41, "potato", 12, "b+"));
            // DisplayCustomer();

            var quitProgram = false;

            while (!quitProgram)
            {
                Console.WriteLine($"-----------------------------------------");
                Console.WriteLine($"Please select a given option below");
                Console.WriteLine($"1.Add New Customer \t2.Add New Medical Insurance \t3.Find Blood Group \t4.Display Customer \t5.Quit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        AddNewCustomer(customerIdRef, ref customerIdRef);
                        break;
                    case "2":
                        AddInsurance();
                        break;
                    case "3":
                        FindBloodGroup();
                        break;
                    case "4":
                        DisplayCustomer();
                        break;
                    case "5":
                        quitProgram = true;
                        break;
                    default:
                        Console.WriteLine($"Please enter a valid option");
                        break;
                }
            }

        }

        public static void AddNewCustomer(int id, ref int customerIdRef)
        {
            Console.WriteLine($"Your Name:");
            var fullName = Console.ReadLine();
            Console.WriteLine($"Your Age:");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Blood Group:");
            var bloodGroup = Console.ReadLine();
            var temp = new CustomerInfo(id, fullName, age, bloodGroup);
            CustomerList.Add(temp);
            customerIdRef++;
        }
        public static void AddInsurance()
        {
            Console.Write($"Select the type of Insurance to apply:\n1.Medical Insurance 2.Life Insurance : ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddMedicalInsurance();
                    break;
                case "2":
                    AddLifeInsurance();
                    break;
                default:
                    Console.WriteLine($"Please enter a valid option");
                    break;
            }
        }
        public static void AddLifeInsurance()
        {
            Console.WriteLine($"Enter the name of the person to apply LifeInsurance");
            var name = Console.ReadLine();
            var customer = Utils.FindCustomer(CustomerList, name);
            if (customer == null)
            {
                Console.WriteLine($"user not found");
            }
            else
            {
                CustomerInfo derivedObj = (CustomerInfo)customer; // here the base class is ICustomerInfo wherer the NewLifeInsurance method is not avaible so we are downcasting to the derived class CustomerInfo
                Console.Write($"Enter the principle amount : ");
                var principleAmount = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the nominee name:");
                var nominee = Console.ReadLine();

                derivedObj.NewLifeInsurance(principleAmount, nominee);
            }
        }
        public static void AddMedicalInsurance()
        {
            Console.WriteLine($"Enter the name of the person to apply Medical Insurance");
            var name = Console.ReadLine();
            var customer = Utils.FindCustomer(CustomerList, name);
            if (customer == null)
            {
                Console.WriteLine($"user not found");
            }
            else
            {
                CustomerInfo derivedObj = (CustomerInfo)customer; // here the base class is ICustomerInfo wherer the NewLifeInsurance method is not avaible so we are downcasting to the derived class CustomerInfo
                Console.Write($"Enter the principle amount : ");
                var principleAmount = double.Parse(Console.ReadLine());

                derivedObj.NewMedicalInsurance(principleAmount);
            }
        }
        public static void FindBloodGroup()
        {

        }
        public static void DisplayCustomer()
        {
            foreach (var customer in CustomerList)
            {
                customer.DisplayInfo();
            }
        }
    }
}
