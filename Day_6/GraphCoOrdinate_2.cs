using System;

namespace CoOrdinate
{
    class Graph
    {
        public int X;
        public int Y;
        public int Z;

        public Graph(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void Move(ref int x, ref int y, ref int z)
        {
            x += 5;
            y += 3;
            z -= 5;
        }

        public void Locate()
        {
            Console.WriteLine($"I'm at {this.X},{this.Y},{this.Z}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3; var y = 2; var z = 9;

            Graph obj1 = new Graph(x, y, z);

            obj1.Locate();
            obj1.Move(ref obj1.X, ref obj1.Y, ref obj1.Z);
            obj1.Locate();

        }
    }
}
