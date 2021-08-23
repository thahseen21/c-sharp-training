using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = 97;
            Console.WriteLine($"Coversion of {temperature} = {temperature.CovertToCelsius()}");

            float[] triangle = { 10.0f, 20.0f };
            Console.WriteLine($"Area of the triangle :{triangle.FindArea()}");

            var empObj = new Employee("Thahseen",20000);
            empObj.ShowEmpDetail();
        }
    }
}
