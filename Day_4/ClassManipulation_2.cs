/* Create a Class called customer with properties customername, customerId  and with two methods – place order , Getcustomertimezone .
 Where the GetCustomerTimeZone  method is static.  
Instantiate the class and call both the methods.  
Copy the object to a new variable and change one of the properties. 
 And display the value of both objects.*/

 // This code is yet to be completed; having doubts in Shallow copy and deep copy.

using System;

namespace ClassManipulation
{

    class Customer
    {
        public string CustomerName;

        public int CustomerId;

        public Customer()
        {
            Console.WriteLine($"New customer.....");
        }

        public Customer(string name, int id)
        {
            CustomerName = name;
            CustomerId = id;
        }

        public string PlaceOrder()
        {
            return ($"Your order has been placed.....");
        }
        public DateTime GetCustomerTimeZone()
        {
            DateTime Day = DateTime.Now;
            return Day;
        }

        public object Shallowcopy()
        {
            return MemberwiseClone();
        }

        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); // Invoking Constructor 
            customer1.CustomerName = "Ram";
            customer1.CustomerId = 21;
            Console.WriteLine($"Customer Name :{customer1.CustomerName} Customer Id :{customer1.CustomerId} Customer TimeZone : {customer1.GetCustomerTimeZone()}\n {customer1.PlaceOrder()} \n\n");

            //Shallow Copy
            Customer shallowCopyCustomer = (Customer)customer1.Shallowcopy();

            shallowCopyCustomer.CustomerName = "Sam";

            Console.WriteLine($"Customer Name :{shallowCopyCustomer.CustomerName} Customer Id :{shallowCopyCustomer.CustomerId} Customer TimeZone : {shallowCopyCustomer.GetCustomerTimeZone()}\n {shallowCopyCustomer.PlaceOrder()}\n\n");
            //Repeating the values using customer1 object to check whether equal or not
            Console.WriteLine($"After Shallow Copy \nCustomer Name :{customer1.CustomerName} Customer Id :{customer1.CustomerId} Customer TimeZone : {customer1.GetCustomerTimeZone()}\n {customer1.PlaceOrder()}\n\n");

            Customer customer2 = new Customer("Seetha", 31); // Parameterised Constructor
            Console.WriteLine($"Customer Name :{customer2.CustomerName} Customer Id :{customer2.CustomerId} Customer TimeZone : {customer2.GetCustomerTimeZone()}\n {customer2.PlaceOrder()}");

        }

    }

}
