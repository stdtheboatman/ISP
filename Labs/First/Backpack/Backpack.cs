using System;
using System.Collections.Generic;

namespace backpack
{
    class Backpack
    {
        List<IBackpackItem> Items { get; }

        public Backpack()
        {
            Items = new List<IBackpackItem>();
        }

        public int GetSize()
        {
            return Items.Count;
        }
        public IBackpackItem GetItem(int index)
        {
            return Items[index];
        }

        public void Add(IBackpackItem item)
        {
            Items.Add(item);
        }

        public void Delete(IBackpackItem item)
        {
            Items.Remove(item);
        }

        public override string ToString()
        {
            string result = "";
            foreach (IBackpackItem item in Items) 
            {
                result += item + "\n";
            }

            return result;
        }
    }
}
