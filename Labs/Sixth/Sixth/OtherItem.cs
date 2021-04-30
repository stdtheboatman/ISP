using System;

namespace Sixth
{
    public class OtherItem : Item, IBackpackItem
    {
        public OtherItem(string name, string description, int weight) : base(name, description, weight)
        {
            //^_^
        }

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
            return "----Other item----\n" +
                   base.ToString() +
                   "------------------";
        }
    }
}