using System;
using Microsoft.CSharp.RuntimeBinder;

namespace Eighth
{
    public class Potion : Item, IBackpackItem
    {
        public Potion(string name, string description,  int weight, string type) : base(name, description, weight)
        {
            this.Type = type; 
        }

        private string Type { get; }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is IBackpackItem == false)
            {
                throw new Exception("Object is not IBackpackItem");
            }

            var other = (IBackpackItem) obj;

            return String.CompareOrdinal(this.Name(), other.Name());
        }

        public new int Weight()
        {
            return base.Weight;
        }

        public new string Name()
        {
            return base.Name;
        }

        public override string ToString()
        {
            return $"----Potion----\n" +
                   base.ToString() +
                   $"Type: {Type}\n" +
                   "---------------\n";
        }
    }
}