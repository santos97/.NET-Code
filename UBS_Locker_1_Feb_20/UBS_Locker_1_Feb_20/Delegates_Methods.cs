using System;
using System.Collections.Generic;
using System.Text;

namespace UBS_Locker_1_Feb_20
{
    abstract class Delegates_Methods: JsonWriter
    {
        protected static void DisplayDelegate(string s)
        {
            Console.WriteLine(s);
        }
        protected static void DisplayRemoveDelegate(string s)
        {
            Console.WriteLine(s);
        }

    }
}
