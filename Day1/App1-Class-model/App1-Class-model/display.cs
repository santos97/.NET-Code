using System;
using System.Collections.Generic;
using System.Text;
using ModelsItem;
using System.Linq;


namespace App1_Class_model
{
    class display
    {
        public void DisplayItems(List<Class1> items)
        {
            Console.WriteLine("The items in the shop are:");
            //foreach (var ele in items)//works best for ref
            //{
            //    Console.WriteLine("{0} - $ {1}", ele.Name, ele.Cost);

            //}


            for (int i = 0; i < items.Count; i++)//works best for val type
            {
                Console.WriteLine("{0} - $ {1}", items[i].Name, items[i].Cost);
            }

            Console.WriteLine("Please select one item.");
            string Selected = Console.ReadLine().ToLower();
            StringBuilder str = new StringBuilder();
            str.Append("You have purchased item ");
            str.Append(Selected);
            Console.WriteLine(str);
            Console.WriteLine("Enter quantity:");
            int Quantity = int.Parse(Console.ReadLine());
            int? ItemCost = items.FirstOrDefault(c => c.Name.ToLower() == Selected)?.Cost;
            TotalDisplay(ItemCost, Quantity, Selected);
            //string st = Item.Name;
            //int cost = Item?.Cost ?? 0;
            //TotalDisplay(Item?.Cost, Quantity, Selected);
        }
        public void TotalDisplay(int? ItemCost, int Quantity, string Selected)
        {
            int total = ItemCost ?? 0 * Quantity;
            Console.WriteLine("Total Cost: " + total);
        }
    }
}
