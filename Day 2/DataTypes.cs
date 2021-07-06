// demo of different DataTypes

using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned byte and signed byte
            byte @byte = 10;
            sbyte @sbyte = 12;

            // unsigned short and signed short
            short @short = 21;
            ushort @ushort = 123;

            // unsigned int and signed int
            int @int = 231;
            uint @uint = 134u;

            // unsigned long and signed long
            long @long = 922337L; // The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity
            ulong @ulong = 12345345ul;

            // float and double 
            float @float = 12123.2323f;
            double @double = 12342343.343434d;

            // decimal
            decimal @decimal = 324235234234m;

            // boolean
            bool @bool = true;

            // string and character 
            string @string = "Hello World!";
            char @char = 'a'; 

            Console.WriteLine("byte :" + @byte);
            Console.WriteLine("sbyte :" + @sbyte);

            Console.WriteLine("short :" + @short);
            Console.WriteLine("ushort :" + @ushort);

            Console.WriteLine("int :" + @int);
            Console.WriteLine("uint :" + @uint);

            Console.WriteLine("long :" + @long);
            Console.WriteLine("ulong :" + @ulong);

            Console.WriteLine("float :" + @float);
            Console.WriteLine("double :" + @double);

            Console.WriteLine("decimal :" + @decimal);

            Console.WriteLine("boolean :" + @bool);

            Console.WriteLine("string :" + @string);

            Console.WriteLine("char :" + @char);

        }
    }
}
