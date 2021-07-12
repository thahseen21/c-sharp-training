using System;

namespace DMS_Type
{

    class DMSConverter
    {

        public double CoOrdinate;
        public DMSConverter(double coOrdinate)
        {
            this.CoOrdinate = coOrdinate;
        }

        public void Converter()
        {
            var degree = Math.Truncate(CoOrdinate);
            var minutes = (this.CoOrdinate - degree) * 60;
            var seconds = Math.Round((minutes - Math.Truncate(minutes)) * 60);
            minutes = Math.Truncate(minutes);
            Console.WriteLine($"The decimal degree of {this.CoOrdinate} = {degree}\x00B0 {minutes}\' {seconds}\"");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"enter a decimal degrees to convert to DMS");
            var coOrdinate = double.Parse(Console.ReadLine());

            DMSConverter obj = new DMSConverter(coOrdinate);
            obj.Converter();
        }
    }
}
