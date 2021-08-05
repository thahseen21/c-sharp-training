using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.InsertElement(20);
            stack.InsertElement(10);

            stack.PopElement();

            stack.InsertElement(50);

            stack.Display();
        }
    }
}
