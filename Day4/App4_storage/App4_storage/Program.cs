using System;
using System.Collections;
using System.Collections.Generic;

namespace App4_storage
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable HtObj = new Hashtable();
            List<Items> item = new List<Items>();
            //storage<Hashtable, int> StorageObj = new storage<Hashtable, int>();
            item.Add(new Items { ID = 10, Item = "Cash", Quantity = 2 });
            item.Add(new Items { ID = 120, Item = "Badge", Quantity = 10 });
            item.Add(new Items { ID = 11, Item = "Photo", Quantity = 12 });
            item.Add(new Items { ID = 101, Item = "Books", Quantity = 1 });
            storage StorageObj = new storage();
            int Select = 0;
            bool exit = true;
            do
            {
                Console.WriteLine("1. Show Items\n2.Add Item\n3.Remove Item\n4.Exit\nEnter your choice");

                Select = int.Parse(Console.ReadLine());
                switch (Select)
                {
                    case 1: StorageObj.GetItem<Hashtable>(HtObj);
                        break;
                    case 2:
                        Console.WriteLine("Enter item ID");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Item Name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Item Quantity");
                        int Quantity = int.Parse(Console.ReadLine());
                        item.Add(new Items { ID = ID, Item = Name, Quantity = Quantity });
                        StorageObj.AddItems<Hashtable, List<Items>>(HtObj, item);
                        break;
                    case 3:
                        StorageObj.GetItem<Hashtable>(HtObj);
                        Console.WriteLine("Enter item ID");
                        int DeleteID = int.Parse(Console.ReadLine());
                        StorageObj.RemoveItem<Hashtable>(HtObj, DeleteID);
                        break;
                    case 4:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;

                }
            } while (exit);
            msg1 Display = new msg1();
            Display.message();
            Display = new msg2();
            Display.message();
        }
    }
    public class msg1
    {
        public virtual void message()
        {
            Console.WriteLine("Welcome to UBS Locker!");
        }

    }
    public class msg2 : msg1
    {
        public override void message()
        {
            Console.WriteLine("Thanks for using to UBS Locker!");
        }
    }
}
//extenstion methods
//file reader
//base
//interface
//c# injection