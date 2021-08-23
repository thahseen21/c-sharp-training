using System;

namespace Test
{
    public static class TemperatureConversion
    {
        public static double CovertToCelsius(this double fahr)
        {
            return ((fahr - 32) * 0.55);
        }
    }
}
