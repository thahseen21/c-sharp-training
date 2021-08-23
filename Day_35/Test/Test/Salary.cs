namespace Test
{
    public class Salary : ISalary
    {
        private double SalaryAmount;

        public Salary()
        {
        }

        public Salary(double salary)
        {
            this.SalaryAmount = salary;
        }

        public double ShowSalary()
        {
            return this.SalaryAmount;
        }

        public double Hike(double percent)
        {
            return this.SalaryAmount * percent;
        }
    }
}
