using System;
using System.Collections;

namespace UBS_Locker_1_Feb_20
{
    delegate void CallerDelegate(string s);
    class Program : Delegates_Methods
    {
        
        static void Main(string[] args)
        {
            Hashtable HtObj = new Hashtable();
            msg1 Display = new msg1();
            //Service<Hashtable> hash = new Service<Hashtable>();
            Service Hash = new Service();
            Display.message();
            JsonReader readerobj = new JsonReader();
            readerobj.LoadJson(HtObj);

            int Select = 0;
            bool exit = true;
            do
            {
                Console.WriteLine("\n\n1. Show Items\n2.Add Item\n3.Remove Item\n4 Get Item Counts\n5.Exit and CheckOut!\nEnter your choice:\n");

                Select = int.Parse(Console.ReadLine());
                switch (Select)
                {
                    case 1:
                        //StorageObj.GetItem<Hashtable>(HtObj);
                        CallerDelegate Caller = new CallerDelegate(DisplayDelegate);
                        Caller("The Items are as Follows:\n");
                        Hash.DisplayItems(ref HtObj);
                        break;
                    case 2:
                        Items ItemsWriter = new Items();
                        Console.WriteLine("Enter item ID");
                        ItemsWriter.ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Item Name");
                        ItemsWriter.Name = Console.ReadLine();
                        Console.WriteLine("Enter Item Quantity");
                        ItemsWriter.Quantity = int.Parse(Console.ReadLine());
                        //item.Add(new Items { ID = ID, Item = Name, Quantity = Quantity });
                        //StorageObj.AddItems<Hashtable, List<Items>>(HtObj, item);
                        Hash.AddItems(ref HtObj, ItemsWriter);
                        break;
                    case 3:
                        //StorageObj.GetItem<Hashtable>(HtObj);
                        Console.WriteLine("Enter item ID");
                        int DeleteID = int.Parse(Console.ReadLine());
                        //StorageObj.RemoveItem<Hashtable>(HtObj, DeleteID);
                        Hash.RemoveItems(ref HtObj, DeleteID);
                        Caller = new CallerDelegate(DisplayRemoveDelegate);
                        Caller("The Items has been removed!\n");
                        break;
                    case 4:
                        dynamic Counts = Hash.HashCounter(HtObj);
                        Counts = (int)Counts;
                        Console.WriteLine("The Number of Items in Locker are: " + Counts);
                        break;
                    case 5:
                        exit = false;
                        ReplaceText(HtObj);
                        Display = new msg2();
                        Display.message();
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;

                }
            } while (exit);

            
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
