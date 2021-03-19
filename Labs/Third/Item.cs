using System;

namespace lab3
{
    public class Item
    {
        
        public Item(string name, string description, int weight)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;

            this.id = objCount++;
        }

        public static void MakeSomething()
        {
            Console.WriteLine($"Было создано {objCount} object Item");
        }

        public override string ToString()
        {
            return $"name: {name}\n" +
                   $"description: {description}\n" +
                   $"weight: {weight}\n" +
                   $"id: {id}" +
                   $"\n";
        }

        public static int objCount { get; private set; }
        
        public int id { get; }
        public string name { get; }
        public string description { get; }
        public int weight { get; }
        
        
    }
}