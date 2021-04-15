using System;
using System.Runtime.Remoting;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old code from 3 lab start");
            OtherItem otherItem = new OtherItem("Грог",
                "Эликсир жизни всех моряков. Не такой сильный как ром, потому и не такой эффективный",
                10);
            
            Console.WriteLine(otherItem);


            Backpack backpack = new Backpack();
            
            backpack.addItem(new OtherItem("Яблоко",
                "Свежее и сочное",
                4));

            backpack.addItem(new OtherItem("Сырое мясо",
                "Можно зажарить на сковороде",
                20));

            backpack.addItem(new OtherItem("Яйцо",
                "Яйцо",
                1));
            
            Console.WriteLine(backpack);
            
            OtherItem.MakeSomething();

            Console.WriteLine(backpack.GetItemsTotalWeight());
            
            backpack.removeItem(1);
            
            Console.WriteLine(backpack);
            
            Console.WriteLine(backpack.GetItemsTotalWeight());

            int i = 1;
            Console.WriteLine($"{i} item in backpack is:\n{backpack[i]}");

            
            // попытка удалить index, которого нет
            try
            {
                backpack.removeItem(100);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            
            Console.WriteLine(backpack);
            
            // попытка 2 удалить index, которого нет

            try
            {
                backpack.removeItem(-100);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            
            Console.WriteLine(backpack);
            
            // попытка взять backpack[index], index которого нет

            try
            {
                Console.WriteLine("ZXC" + backpack[100]);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            
            Console.WriteLine(backpack);
            
            Console.WriteLine("Old code from 3 lab end\n\n\n\n\n\n");

























            Item potion = new Potion("Зелье взломщика",
                "Взлом облегчается на 20 % в течение 30 секунд.",
                1,
                "Улучшение умений.");
            
            Console.WriteLine(potion);

            Item weapon = new Weapon("Бритва Мерунеса.",
                "Этот кинжал — артефакт Даэдрического Принца Мерунеса Дагона. Это оружие способно мгновенно уничтожить любое живое существо.",
                3,
                11,
                "Кинжал. Артефакт Даэдра.");

            
            Console.WriteLine(weapon);
            
            Item weapon1 = new Weapon("Вутрад.",
                "Это легендарная секира покорителя Скайрима, первого Предвестника, великого Исграмора. С её помощью он очистил Скайрим для нордов, когда со своими пятью сотнями утопил его в крови изначально обитавших здесь меров.",
                25,
                25,
                "Секира");
            
            backpack.Clear();

            backpack.addItem(potion);
            backpack.addItem(weapon);
            backpack.addItem(weapon1);
            
            Console.WriteLine(backpack);
            
            backpack.SharpenAllWeapons((int)BlacksmithLevel.Adept);
            
            Console.WriteLine(backpack);

            backpack.SharpenAllWeapons((int)BlacksmithLevel.Adept);
            
            Console.WriteLine(backpack);
        }
    }
}