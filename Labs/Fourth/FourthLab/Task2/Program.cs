using System;
using System.Runtime.InteropServices;

namespace Task2
{
    class Program
    {
        [DllImport("myLib.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Gcd(int a, int b);

        [DllImport("myLib.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Min(int a, int b);

        [DllImport("myLib.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Max(int a, int b);

        [DllImport("myLib.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Pow(int a, int n);


        static void Main(string[] args)
        {
            Console.WriteLine("Min");
            Console.WriteLine("Min(2, 3) = {0}", Min(2, 3));
            Console.WriteLine("Min(4, 2) = {0}", Min(4, 2));
            Console.WriteLine();

            Console.WriteLine("Max");
            Console.WriteLine("Max(2, 3) = {0}", Max(2, 3));
            Console.WriteLine("Max(4, 2) = {0}", Max(4, 2));
            Console.WriteLine();


            Console.WriteLine("Gcd");
            Console.WriteLine("Gcd(2, 3) = {0}", Gcd(2, 3));
            Console.WriteLine("Gcd(3, 2) = {0}", Gcd(3, 2));
            
            Console.WriteLine("Gcd(6, 12) = {0}", Gcd(6, 12));
            Console.WriteLine("Gcd(10, 35) = {0}", Gcd(10, 35));
            Console.WriteLine();


            Console.WriteLine("Pow");
            Console.WriteLine("Pow(2, 3) = {0}", Pow(2, 3));
            Console.WriteLine("Pow(3, 2) = {0}", Pow(3, 2));

            Console.WriteLine("Pow(2, 4) = {0}", Pow(2, 4));
            Console.WriteLine("Pow(3, 7) = {0}", Pow(3, 7));
            Console.WriteLine();





        }
    }
}