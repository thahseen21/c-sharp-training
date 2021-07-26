using System;

namespace Project
{
    public interface ICustomerInfo
    {
        int Id { get; }
        string Name { get; }
        int Age { get; }
        string BloodGroup { get; }
        void DisplayInfo();
    }
}
