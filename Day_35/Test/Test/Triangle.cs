using System;

namespace Test
{
    public static class Triangle
    {
        public static double FindArea(this float[] triangle) // triangle:[base,height]
        {
            return (0.5 * triangle[0] * triangle[1]);
        }
    }
}
