using System;
using System.Collections.Generic;

namespace GenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>() { { 10, "21323" }, { 41, "asdf" } };

            // myDictionary.Add("potato", 2010);

            DictionaryUtils.MyAdd<int, string>(21, "2002", myDictionary);
            DictionaryUtils.MyAdd<int, string>(11, "2202", myDictionary);
            DictionaryUtils.MyAdd<int, string>(22, "2003", myDictionary);
            DictionaryUtils.MyAdd<int, string>(23, "2004", myDictionary);

            DictionaryUtils.MyRemove<int>(23, myDictionary);

            foreach (KeyValuePair<int, string> entry in myDictionary)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }
    }
}
