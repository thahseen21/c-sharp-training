using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    static public class Utils
    {
        public static ICustomerInfo FindCustomer(List<ICustomerInfo> customerList, string name)
        {
            foreach (var customer in customerList)
            {
                if (name.Equals(customer.Name.ToLower()))
                {
                    return customer;
                }
            }
            return null;
        }
        public static IEnumerable<ICustomerInfo> FindBloodGroup(List<ICustomerInfo> customerList, string bloodGroup)
        {
            List<ICustomerInfo> NewCustomerList = new List<ICustomerInfo>();


            var data = from item in customerList
                       where item.BloodGroup.ToLower().Contains(bloodGroup)
                       where item.IsMedicalInsured == true
                       select item;
            foreach (var item in data)
            {
                Console.WriteLine($"item:{item.Name}");
            }
            return data;
        }
    }
}