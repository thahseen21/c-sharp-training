// C# program to demonstrate CLSCompliantAttribute
// giving a warning message
using System;
  
// CLSCompliantAttribute applied to entire assembly
[assembly:CLSCompliant(true)]
  
    public class GFG {
    public uint z;
}
  
class GFG2 {
  
// Main Method
public static void Main(string[] args)
{
    Console.WriteLine("GeeksForGeeks");
}
  
}