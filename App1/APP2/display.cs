using System;
using System.Collections.Generic;
using System.Text;

namespace APP2
{
    class display
    {
        public void DisplayItems(IDictionary<string, int> items)
        {
            Console.WriteLine("The items in the shop are:");
            foreach (KeyValuePair<string,int> ele1 in items)
            {
                Console.WriteLine("{0} - $ {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine("Please select one item.");
            string Selected = Console.ReadLine().ToLower();
            StringBuilder str = new StringBuilder();
            str.Append("You have purchased item ");
            str.Append(Selected);
            Console.WriteLine(str);
            Console.WriteLine("Enter quantity:");
            int Quantity = int.Parse(Console.ReadLine());
            int ItemCost = items[Selected];
            TotalDisplay(ItemCost,Quantity, Selected);
        }
        public void TotalDisplay(int ItemCost, int Quantity, string Selected)
        {
            int total = ItemCost * Quantity;
            Console.WriteLine("Total Cost: " + total);
        }
    }
}
