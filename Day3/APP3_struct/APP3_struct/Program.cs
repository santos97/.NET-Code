using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace APP3_struct
{
    public partial class msg
    {
        public void dis2()
        {
            Console.WriteLine("Thank you for Shopping with us!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List < Items > items= new List<Items>();
            items.Add(new Items{ ID="zx123",
                Name = "Mosue",
                Cost = 10,
                ItemTypes = Itypes.Electronics
            });
            items.Add(new Items
            {
                ID = "zx113",
                Name = "Table",
                Cost = 50,
                ItemTypes = Itypes.Furniture
            }); ;
            items.Add(new Items
            {
                ID = "zx193",
                Name = "Macbook Pro",
                Cost = 1000,
                ItemTypes = Itypes.Electronics
            });

            StructModel model = new StructModel();
            msg dispfinal = new msg();
            dispfinal.dis1();

            model.DisplayItems(items);
            dispfinal.CombineAll(model.ItemCost, model.itype, model.Selected);
            dispfinal.dis2();
            //MultiTasking.FindIt(keytype,Calculate.Itypes);

        }

    }
    //public static class multitasking
    //{
    //    static void findit(int? keytype, enum itypes)
    //    {
    //        public static int n = 14;
    //        parallel.for(0, 1, i =>{
    //            foreach(int k in enum.getvalues(typeof(itypes)))
    //            {
    //                console.writeline($" {i}");
    //            } });


    //    }
    //}
}
//NEXT topics
//base
//virtual
//general