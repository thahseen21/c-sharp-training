using System;
using System.Collections.Generic;

namespace GenericAssignment
{
    static class DictionaryUtils
    {
        public static void MyAdd<T, U>(T key, U value, Dictionary<T, U> myDictionary) // here T and U represents different type
        {
            myDictionary.Add(key, value);
        }
        public static void MyRemove<T>(T key, Dictionary<T, string> myDictionary)
        {
            myDictionary.Remove(key);
        }
    }
}