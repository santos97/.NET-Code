using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APP3_struct
{
    abstract partial class Calculate //Abstract Class
    {
        
        public void TotalDisplay(ref int ItemCost, int Quantity, string Selected)
        {
            int total = ItemCost * Quantity;
            ItemCost += 120+ total;
            Console.WriteLine("Total Cost: " + total);
        }
        
    }
}
