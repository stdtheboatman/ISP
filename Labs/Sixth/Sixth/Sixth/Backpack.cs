#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sixth
{
    public class Backpack

    {
    public IBackpackItem this[int index]
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
        foreach (var item in list)
        {
            result += item.ToString() + "\n";
        }

        return result;
    }

    public void AddItem(IBackpackItem item)
    {
        list.Add(item);
    }

    public void SharpenAllWeapons(int skillLevel)
    {
        foreach (var item in list)
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

    public void RemoveItem(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new Exception("backpack doesnt have this index");
        }

        list.RemoveAt(index);
    }

    public void SortByName()
    {
        list.Sort();
    }

    private int CompareByWeight(IBackpackItem a, IBackpackItem b)
    {
        return a.Weight().CompareTo(b.Weight());
    }

    public void SortByWeight()
    {
        list.Sort(CompareByWeight);
    }

    public string GetItemsTotalWeight()
    {
        int sum = 0;
        foreach (var item in list)
        {
            sum += item.Weight();
        }

        return $"Total weight is: {sum}\n";
    }

    private List<IBackpackItem> list = new List<IBackpackItem>();
    }
}