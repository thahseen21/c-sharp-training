using System;
using System.Collections.Generic;

namespace stack
{
    class Stack
    {
        public static void operator +(int[] stack, int top)
        {
            stack[top] = 10;
        }
    }
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int top = 0;
            int[] stack = new int[10];

            +Stack(stack, 0);

        }
    }
}
