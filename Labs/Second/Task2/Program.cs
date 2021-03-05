using System;

namespace task2
{
    class Program
    {
        static string GetRandomString()
        {
            Random rnd = new Random();

            int strSize = rnd.Next(1, 5);
            string str = "";

            for(int i = 0; i < strSize; i++)
            {
                str += (char)('a' + rnd.Next(0, 25));
            }

            return str;

        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 16; i++)
            {
                Console.WriteLine(GetRandomString());
            }
        }
    }
}
