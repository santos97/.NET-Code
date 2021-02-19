using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace App4_storage
{
    class storage//<H, L> where H:class where L : struct  //multiple generic type
    {
        public int Hour { get;set;}
        public void AddItems<H, L>(HashSet <H> HtObj,List<L> ItemsList)
        {
            Console.WriteLine("Adding Items");
            var res = ItemsList;
            //foreach (var ItemObj in ItemsList) {
            //    HtObj.Add(ItemObj.ID, ItemsList);

            //}
            //for (int i = 0; i < ItemsList.; i++)
            //{
            //    var dataStoreList = values.Select((v, i) => new ItemsList { index = i, value = v }).ToList();
            //    HtObj.Add(ItemsList[i]., ItemsList);
            //}


        }
        //public void GetItem<H>(H HtObj)
        //{
        //    ICollection key = HtObj.Keys;

        //    for (int i = 0; i < HtObj.Count; i++)
        //    {
        //        Console.WriteLine("{0} {1} {2}", ItemsList[i].ID, ItemsList[i].Name, ItemsList[i].Quantity);
        //        Console.WriteLine(k + ": " + HtObj[k]);
        //    }
        //    Console.WriteLine("The Items in storage are:\n");
        //    for (int i = 0; i < ItemsList.Count; i++)
        //    {
        //        Console.WriteLine("{0} {1} {2}",ItemsList[i].ID, ItemsList[i].Name,ItemsList[i].Quantity);
        //    }
        //}

        //public void RemoveItem<H>(H HtObj,int ID)
        //{
        //    HtObj.Remove(ID);
        //}

    }
}
