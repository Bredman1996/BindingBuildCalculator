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
        public string effect { get; set; }
        public string[] effectedStats { get; set; }

        public Item()
        {

        }
        public Item(string name, string description, string effect, string[] effectedStats)
        {
            this.name = name;
            this.description = description;
            this.effect = effect;
            this.effectedStats = effectedStats;
        }

        public static string addItem()
        {
            Item thing = new Item();
            thing.name = "MyName";
            thing.effect = "MyEffect";
            thing.description = "MyDescription";
            thing.effectedStats = new string[] { "Nope", "Yup"};
            String output = JsonConvert.SerializeObject(thing);

            return output;
        }

    }
}
