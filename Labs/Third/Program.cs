using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("Грог",
                "Эликсир жизни всех моряков. Не такой сильный как ром, потому и не такой эффективный",
                10);
            
            Console.WriteLine(item);


            Backpack backpack = new Backpack();
            
            backpack.addItem("Яблоко",
                "Свежее и сочное",
                4);

            backpack.addItem("Сырое мясо",
                "Можно зажарить на сковороде",
                20);

            backpack.addItem("Яйцо",
                "Яйцо",
                1);
            
            Console.WriteLine(backpack);
            
            Item.MakeSomething();

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
            
        }
    }
}