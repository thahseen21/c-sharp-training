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
        public static List<ICustomerInfo> FindBloodGroup(List<ICustomerInfo> customerList, string bloodGroup)
        {
            // List<ICustomerInfo> NewCustomerList = new List<ICustomerInfo>();
            // foreach (var customer in customerList)
            // {

            // }
            // NewCustomerList = from customer in customerList
            //                   where customer.BloodGroup equals bloodGroup
            //                   select customer;
            // return NewCustomerList;
        }
    }
}