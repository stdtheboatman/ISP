using System;

namespace task1
{
    class Program
    {
        static string ReverseWordOrder(string text)
        {
            string[] words = text.Split(" ");
            Array.Reverse(words);

            return string.Join(" ", words);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();

            s = ReverseWordOrder(s);
            Console.WriteLine(s);
        }
    }
}
