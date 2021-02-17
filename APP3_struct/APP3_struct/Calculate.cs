using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APP3_struct
{
    abstract partial class Calculate //Abstract Class
    {
        public enum Itypes
        {
            Electronics = 1,
            Furniture = 2,
            Chemicals=3,
            Organic=4,
            BioMolecular=5,
            MineralOre=6,
            Cloths=7,
            Petroleum=8,
            Ceramics=9,
            Nuclear=10,
            Vegitables=11,
            Shoes=12,
            Beauty=13,
            Medicine=14
        }
        public void TotalDisplay(ref int? ItemCost, int Quantity, string Selected)
        {
            int total = ItemCost ?? 0 * Quantity;
            ItemCost += 120+ total;
            Console.WriteLine("Total Cost: " + total);
        }
        
    }
}
