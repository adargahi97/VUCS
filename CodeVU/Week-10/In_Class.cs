using System;
using System.Collections.Generic;

namespace Week_10
{
    internal class In_Class
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> inventory = new Dictionary<string, List<string>>();
            inventory["gold"] = new List<string> { "500" };
            inventory["pouch"] = new List<string> { "flint", "twine", "gemstone" };
            inventory["backpack"] = new List<string> { "xylophone", "dagger", "bedroll", "bread loaf" };

            foreach (string item in inventory["backpack"]) { Console.WriteLine(item); }
            inventory.Add("pocket", new List<string> { "seashell", "strange berry", "lint" });
            inventory["backpack"].Sort();
            inventory["backpack"].Remove("dagger");
            foreach (string item in inventory["backpack"]) { Console.WriteLine(item); }
            inventory["gold"][0] = Convert.ToString(int.Parse(inventory["gold"][0]) + 50);


            Dictionary<string, Dictionary<string, double>> produce = new Dictionary<string, Dictionary<string, double>>();
            produce["banana"] = new Dictionary<string, double> { { "price", 4 }, { "stock", 2 } };
            produce["apple"] = new Dictionary<string, double> { { "price", 2 }, { "stock", 0 } };
            produce["orange"] = new Dictionary<string, double> { { "price", 1.5 }, { "stock", 5 } };
            produce["pear"] = new Dictionary<string, double> { { "price", 3 }, { "stock", 8 } };

            foreach (var kvp in produce["banana"]) { Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value); }





        }
    }
}
