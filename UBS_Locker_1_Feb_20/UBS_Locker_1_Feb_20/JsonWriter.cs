using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace UBS_Locker_1_Feb_20
{
    public class JsonWriter
    {
        public static string Path = "C:\\.NET Training\\UBS_Locker_1_Feb_20\\UBS_Locker_1_Feb_20\\Items3.json";
        public static void ReplaceText(Hashtable hash)
        {

            ICollection c = hash.Keys;

            List<Items> _data = new List<Items>();
            foreach (int i in c)
            {
                Items ItemsReader = (Items)hash[i]; 
                _data.Add(new Items()
                {
                    ID = ItemsReader.ID,
                    Name = ItemsReader.Name,
                    Quantity = ItemsReader.Quantity
                });
            }
            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText(Path, json);
            
            //try
            //{
            //    string text = File.ReadAllText(Path);
            //    text = text.Replace(text, "");
            //    File.WriteAllText(Path, text);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            
        }
    }
}
