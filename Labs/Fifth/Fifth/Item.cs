using System;

namespace Fifth
{
    public struct ItemInfo
    {
        public ItemInfo(string name, string description, int weight)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
        }
        
        public string name;
        public string description;
        public int weight;
    }

    public abstract class Item
    {
        public Item(string name, string description, int weight)
        {
            info = new ItemInfo(name, description, weight);
            this.id = objCount++;
        }

        public Item(Item item)
        {
            info = item.info;
            id = item.id;
        }

        private ItemInfo info;

        public int weight
        {
            get
            {
                return info.weight;
            }
        }

        public int id { get; }

        public static int objCount { get; private set; }

        public static void MakeSomething()
        {
            Console.WriteLine($"Было создано {objCount} object Item");
        }
        public abstract override string ToString();
        
        public string CommonInfoToString()
        {
            return $"Name: {info.name}\n" +
                   $"Description: {info.description}\n" +
                   $"Weight: {info.weight}\n";
        }
    }
}