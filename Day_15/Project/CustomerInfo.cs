using System;

namespace Project
{
    public class CustomerInfo : ICustomerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public bool IsMedicalInsured { get; set; }
        public bool IsLifeInsured { get; set; }

        private int LifeInsuranceIdRef = 1;
        private int MedInsuranceIdRef = 1;

        MedicalInsurance medicalInsurance;
        LifeInsurance lifeInsurance;
        public CustomerInfo(int id, string name, int age, string bloodGroup)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.BloodGroup = bloodGroup;
        }

        public void DisplayInfo()
        {
            var medInsurance = IsMedicalInsured ? "Insured" : "Not Insured";
            var isLifeInsured = IsLifeInsured ? "Insured" : "Not Insured";

            Console.WriteLine($"-----------------------------------------");

            Console.WriteLine($"Id :{this.Id}\nName:{this.Name}\nAge:{this.Age}\nBloodGroup:{this.BloodGroup}\nMedical Insurance:{medInsurance}\nLife Insurance:{isLifeInsured}");

            Console.WriteLine($"-----------------------------------------");
        }

        public void NewLifeInsurance(double premiumAmount, string nominee)
        {
            if (!IsLifeInsured)
            {
                lifeInsurance = new LifeInsurance(this.LifeInsuranceIdRef, DateTime.Now, this.Id, premiumAmount, nominee);
                lifeInsurance = new LifeInsurance(this.LifeInsuranceIdRef, DateTime.Now, this.Id, premiumAmount, nominee);
                this.IsLifeInsured = true;
            }
            else
            {
                Console.WriteLine($"You already have a life insurance");
                return;
            }

            Console.WriteLine($"New Life Insurance has been created...");
        }
        public void NewMedicalInsurance(double premiumAmount)
        {
            if (!IsMedicalInsured)
            {
                medicalInsurance = new MedicalInsurance(MedInsuranceIdRef, DateTime.Now, this.Id, premiumAmount);
                MedInsuranceIdRef++;
                this.IsMedicalInsured = true;
                Console.WriteLine($"New Medical Insurance has been created...");
            }
            else
            {
                Console.WriteLine($"You already have a Medical Insurance");
                return;
            }
        }
    }
}
