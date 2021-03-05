using System;

namespace backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack backpack = new Backpack();

            backpack.Add(new Pizza(20, 10, "A"));
            backpack.Add(new Pizza(100, 10, "B"));
            backpack.Add(new Pizza(10, 30, "C"));


            BackpackLogic backpackLogic = new BackpackLogic(backpack);

            Console.WriteLine(backpack);

            backpackLogic.SolveBackpack(30);
            Console.WriteLine(backpackLogic);

            backpackLogic.SolveBackpack(29);
            Console.WriteLine(backpackLogic);
        }
    }
}
