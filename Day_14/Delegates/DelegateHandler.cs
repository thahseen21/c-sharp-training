using System;

namespace DelegateAssignment
{
    public class DelegateHandler
    {
        public delegate string StringManipulationHandler(string data);
        public delegate string StringManipulationHandler2(string data1, string data2);

        static public string StringManipulate(string data, StringManipulationHandler stringManipulationHandler)
        {
            return stringManipulationHandler(data);
        }
        static public string StringManipulate2(string data1, string data2, StringManipulationHandler2 stringManipulationHandler)
        {
            return stringManipulationHandler(data1, data2);
        }
    }
}