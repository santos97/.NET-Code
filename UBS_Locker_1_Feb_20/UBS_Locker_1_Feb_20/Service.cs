using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UBS_Locker_1_Feb_20
{
    class Service //<T> where T: class
    {
        //public void DisplayItems<T>(ref T hash)
        public void DisplayItems(ref Hashtable hash)
        {
            //Hashtable TableDisp = hash;
            ICollection c = hash.Keys;

            foreach (int i in c)
            {
                Items ItemsReader = (Items)hash[i];
                Console.WriteLine("ID: {0}\t\t\t Item_Name:{1} \t\t\tQuantity:{2}", i, ItemsReader.Name, ItemsReader.Quantity);
            }
        }
        //public void AddItems<T>(ref T hash, Items ItemsWriter)
        public void AddItems(ref Hashtable hash, Items ItemsWriter)
        {
            hash.Add(ItemsWriter.ID, ItemsWriter);
        }
        //public void RemoveItems<T>(ref  hash, int ID)
        public void RemoveItems(ref Hashtable hash, int ID)
        {
            hash.Remove(ID);
        }
        public int HashCounter(Hashtable hash)
        {
            int Counts = hash.Count;
            return Counts;
        }
    }
}
