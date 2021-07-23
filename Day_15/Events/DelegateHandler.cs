using System;

namespace DelegateAssignment
{
    public class DelegateHandler
    {
        public delegate string StringManipulationHandler(string source, EventArgs args);

        public event StringManipulationHandler myEvent;

        public virtual string OnStringManipulationEvent(string data)
        {
            return myEvent?.Invoke(data, EventArgs.Empty);
            // if (myEvent != null)
            // myEvent(this, EventArgs.Empty);
        }
        public string StringManipulate(string data)
        {
            return OnStringManipulationEvent(data);
        }
        public delegate string StringManipulationHandler2(string data1, string data2);

        static public string StringManipulate2(string data1, string data2, StringManipulationHandler2 stringManipulationHandler)
        {
            return stringManipulationHandler(data1, data2);
        }
    }
}