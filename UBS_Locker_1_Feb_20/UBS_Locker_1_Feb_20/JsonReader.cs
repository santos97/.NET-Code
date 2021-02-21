using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Collections;

namespace UBS_Locker_1_Feb_20
{
    class JsonReader: Items
    {
        //Items item = new Items();
        public void LoadJson(Hashtable hash)
        {
            string Path = "C:\\.NET Training\\UBS_Locker_1_Feb_20\\UBS_Locker_1_Feb_20\\Items3.json";
            string JsonFromFile;
            try
            {
                using (StreamReader reader = new StreamReader(Path))
                {
                    JsonFromFile = reader.ReadToEnd();
                    //Items = JsonSerializer.Deserialize<Items>(jsonString);
                    //Console.WriteLine(JsonFromFile+"---\n");
                    List<Items> items = JsonConvert.DeserializeObject<List<Items>>(JsonFromFile);
                    //dynamic array = JsonConvert.DeserializeObject(JsonFromFile);
                    foreach (var item in items)
                    {
                        //Console.WriteLine("{0} {1} {2}", item.ID, item.Name, item.Quantity);
                        hash.Add(item.ID,item);
                    }
                    ICollection c = hash.Keys;

                    // Displaying the contents 
                    //Items ItemsReader = new Items();
                    foreach (int i in c)
                    {
                        Items ItemsReader = (Items)hash[i]; 
                        Console.WriteLine("ID: {0}\t\t\t Item_Name:{1} \t\t\tQuantity:{2}", i, ItemsReader.Name,ItemsReader.Quantity);
                    }
                }
            }
            catch(FileLoadException f)
            {
                Console.WriteLine("File load error!" + f);
            }
            catch(Exception e)
            {
                Console.WriteLine("File Reade error!"+e);
            }
        }
    }
    public class Items
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

}
