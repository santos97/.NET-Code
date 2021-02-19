using System;
using System.Collections.Generic;
using System.Text;

namespace App4_printer
{
    public class DisplayInt
    {
        public virtual void DisplayOutput<T>(T a, T b)
        {
            Console.WriteLine("From DisplayInt Class \nINT values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
    public class DisplayChar : DisplayInt
    {
        public override void DisplayOutput<T>( T c, T d)
        {
            Console.WriteLine("From DisplayChar Class.\nCHAR values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
        }
    }
    public class DisplayObject : DisplayChar
    {
        public override void DisplayOutput<T>(T k, T l)
        {
            Console.WriteLine("From DisplayObject Class.\nObject values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", k, l);
        }
    }
}
