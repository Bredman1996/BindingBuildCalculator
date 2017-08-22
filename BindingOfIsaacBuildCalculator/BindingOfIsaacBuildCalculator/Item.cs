using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BindingOfIsaacBuildCalculator
{
    class Item
    {
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string[] effectedStats { get; set; }

        public Item()
        {

        }
        public Item(string name, string description, string type, string[] effectedStats)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.effectedStats = effectedStats;
        }

        public static List<Item> getItem()
        {
            List<Item> items = new List<Item>();
            //Directory.SetCurrentDirectory(@"../../../../");
            string file = @"D:\CodingProjects\Binding\BindingOfIsaacBuildCalculator\BindingOfIsaacBuildCalculator\JsonFiles\items.json";
            using (StreamReader reader = File.OpenText(file))
            {
                while (reader.EndOfStream == false)
                {
                    string itemString = reader.ReadLine();
                    Item item = JsonConvert.DeserializeObject<Item>(itemString);
                    items.Add(item);
                }
                reader.Dispose();
            }
            return items;
        }

        public override string ToString()
        {
            String output = this.name;

            return output;
        }

    }
}
