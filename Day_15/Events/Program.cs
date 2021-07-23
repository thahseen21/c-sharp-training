// Delegates

// Create multiple string manipulation methods like
// a ) Removes white spaces with underscore 
// b)  String reverse 
// c)  join multiple strings 
// d)  find the character and number of occurrence in a string /  text 
// Try to access these methods using Delegate 

using System;

namespace DelegateAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal dsistribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on ";

            var inputData2 = "Lorem";

            var obj1 = new DelegateHandler();

            obj1.myEvent += StringUtils.ReplaceByUnderscore;
            obj1.myEvent += StringUtils.ReverseString;

            obj1.StringManipulate(inputData);

            DelegateHandler.StringManipulationHandler2 handler2 = StringUtils.JoinString;
            handler2 += StringUtils.FindAndCount;
            DelegateHandler.StringManipulate2(inputData, inputData2, handler2);

        }
    }
}
