using System;

namespace Project
{
    public interface ICustomerInfo
    {
        int Id { get; }
        string Name { get; }
        int Age { get; }
        string BloodGroup { get; }
        bool IsMedicalInsured { get; set; }
        bool IsLifeInsured { get; set; }

        void DisplayInfo();
    }
}
