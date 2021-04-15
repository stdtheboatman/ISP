using System;
using System.Collections.Generic;
using System.Linq;

namespace Fifth
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

        public void addItem(Item item)
        {
            list.Add(item);
        }

        public void SharpenAllWeapons(int skillLevel)
        {
            foreach (Item item in list)
            {
                    Weapon weapon = item as Weapon;

                    if (weapon != null)
                    {
                        weapon.Sharpen(skillLevel);
                    }
            }
            
        }
        public void Clear()
        {
            list.Clear();
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