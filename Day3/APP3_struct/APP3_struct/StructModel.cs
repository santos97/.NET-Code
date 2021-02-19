using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APP3_struct
{
    public partial class msg
    {
        public void dis1()
        {
            Console.WriteLine("Hello! Welcome to Big Bazzar");
        }
        public void CombineAll(int? FinalCost, int? keytype, String ItemSelected)
        {
            StringBuilder str = new StringBuilder();
            str.Append("The selected item is ");
            str.Append(ItemSelected);
            str.Append(".\nCompany unique product number is ");
            str.Append(keytype);
            str.Append(".\nThe final cost is");
            str.Append(FinalCost);
            Console.WriteLine(str);
        }
    }
    struct Items
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public Itypes ItemTypes { get; set; }
    }
     class StructModel : Calculate
    {
        //Calculate AddTax = new Calculate();
        public int itype;
        public int ItemCost;
        public String Selected;
        public void DisplayItems(List<Items> items)
        {
            Console.WriteLine("The Items available are:\n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0} {1} - $ {2}",items[i].ID ,items[i].Name, items[i].Cost);
            }
            Console.WriteLine("Please select one item!");
            Selected = Console.ReadLine(); //Reference Type
            Console.WriteLine("Enter quantity:");
            int EnteredQuantity = int.Parse(Console.ReadLine()); //object type
            int Quantity = EnteredQuantity; //unboxing
            ItemCost = items.FirstOrDefault(c => c.Name == Selected).Cost;
            itype = (int)items.FirstOrDefault(c => c.Name == Selected).ItemTypes;
            TotalDisplay(ref ItemCost, Quantity, Selected); //pass as ref
            //Console.WriteLine("Item Cost with TAX:" + ItemCost); // value change of ItemCost
        }
        
    }
}
