using ModelsItem;
using System;
using System.Collections.Generic;

namespace App1_Class_model
{
    class Program
    {
        static void Main(string[] args)
        {
            display dis = new display();
            List<Class1> itemmod = new List<Class1>();
            itemmod.Add(new Class1 { ID = "id123", Name = "Chair", Cost = 100 });
            itemmod.Add(new Class1 { ID = "id110", Name = "Headset", Cost = 10 });
            Console.WriteLine("Hello!");
            dis.DisplayItems(itemmod);


        }
    }
}
