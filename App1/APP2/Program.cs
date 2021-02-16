using System;
namespace APP2
{
    class Program
    {   //main driver code
        
        static void Main(string[] args)
        {
            display dis = new display();
            model mod = new model();

            Console.WriteLine("Hello!");

            dis.DisplayItems(mod.items);


        }
    }
}
