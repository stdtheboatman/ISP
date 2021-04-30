using System;

namespace Sixth
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Weapon[] weapons =
            {
                new Weapon("Лук Ауриэля.",
                    "Это один из мощнейших артефактов, когда-либо существовавших в Тамриэле.",
                    11,
                    13,
                    "Лук."),
                
                new Weapon("Счастливый кинжал Вальдра.",
                    "25 % вероятность критического удара.",
                    2,
                    5,
                    "Кинжал."),
                
                new Weapon("Вутрад.",
                    "Это легендарная секира покорителя Скайрима, первого Предвестника, великого Исграмора. С её помощью он очистил Скайрим для нордов, когда со своими пятью сотнями утопил его в крови изначально обитавших здесь меров.",
                    25,
                    25,
                    "Секира.")
            };

            Potion[] potions =
            {
                new Potion(
                    "Смертельная отрава.",
                    "Наносит противнику 3 единицы урона ядом в течение 20 секунд.",
                    1,
                    "Яд."),

                new Potion(
                    "Крепкое зелье запаса сил.",
                    "Восстанавливает 100 единиц запаса сил.",
                    1,
                    "Зелье.")
            };

            OtherItem[] otherItems =
            {
                new OtherItem(
                    "Гномы, том 2.",
                    " ходе нашего предыдущего обсуждения гномов (или «двемеров», говоря более точным, научным языком) мы рассмотрели особенности гномьей архитектуры и металлических изделий.",
                    1
                )
            };

            Backpack backpack = new Backpack();

            foreach (var weapon in weapons)
            {
                backpack.AddItem(weapon);
            }
            
            foreach (var potion in potions)
            {
                backpack.AddItem(potion);
            }
            
            foreach (var otherItem in otherItems)
            {
                backpack.AddItem(otherItem);
            }

            
            Console.WriteLine(backpack);
            Console.WriteLine("\n");


            backpack.SortByName();
            Console.WriteLine("Start sort by Name\n");
            Console.WriteLine(backpack + "\n\n\n");
            
            backpack.SortByWeight();
            Console.WriteLine("Start sort by Weight\n");
            Console.WriteLine(backpack);

        }
    }
}