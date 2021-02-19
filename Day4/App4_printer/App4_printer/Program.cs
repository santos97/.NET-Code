using System;

namespace App4_printer
{
    partial class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 1000;
            b = 120;
            c = 'S';
            d = 'Z';
            object k, l;

            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.WriteLine("\n\n Trying with custom object input");
            Console.WriteLine("Enter first object type value");
            k = Console.ReadLine();
            Console.WriteLine("Enter second object type value");
            l = Console.ReadLine();
            Console.WriteLine("Object values before swapping\nc = {0}, d = {1}", k, l);


            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            Swap<object>(ref k, ref l);
            DisplayInt DisplayObj = new DisplayInt();
            DisplayObj.DisplayOutput(a,b);
            DisplayObj = new DisplayChar();
            DisplayObj.DisplayOutput(c, d);
            DisplayObj = new DisplayObject();
            DisplayObj.DisplayOutput(k, l);


            Console.ReadKey();
        }
        
    }
    

}
