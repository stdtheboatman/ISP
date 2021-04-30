using System;

namespace Sixth
{
    public readonly struct ItemBasicInformation
    {
        public ItemBasicInformation(string name, string description, int weight)
        {
            this.Name = name;
            this.Description = description;
            this.Weight = weight;
        }

        public readonly string Name;
        public readonly string Description;
        public readonly int Weight;
    }

    public class Item
    {
        public Item(string name, string description, int weight)
        {
            _basicInformation = new ItemBasicInformation(name, description, weight);
            this.Id = ObjCount++;
        }

        private readonly ItemBasicInformation _basicInformation;

        public int Weight => _basicInformation.Weight;
        public string Name => _basicInformation.Name;

        private int Id { get; }

        private static int ObjCount { get; set; }

        public static void MakeSomething()
        {
            Console.WriteLine($"Было создано {ObjCount} object Item");
        }

        public override string ToString()
        {
            return $"Name: {_basicInformation.Name}\n" +
                   $"Description: {_basicInformation.Description}\n" +
                   $"Weight: {_basicInformation.Weight}\n";
        }
    }
}