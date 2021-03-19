using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class Backpack
    {
        public Item this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Count)
                {
                    throw new Exception("backpack doesnt have this index");
                }
                
                return list[index];
            }
        }
        
        public override string ToString()
        {
            string result = "";
            foreach (Item item in list)
            {
                result += item + "--------\n";
            }

            return result;
        }

        public void addItem(string name, string description, int weight)
        {
            list.Add(new Item(name, description, weight));
        }

        public void removeItem(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new Exception("backpack doesnt have this index");
            }

            list.RemoveAt(index);
        }

        public string GetItemsTotalWeight()
        {
            int sum = 0;
            foreach (Item item in list)
            {
                sum += item.weight;
            }

            return $"Total weight is: {sum}\n";
        }

        private List<Item> list = new List<Item>();
    }
}