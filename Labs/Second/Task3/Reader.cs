using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public class Reader
    {
        public static Int64 ReadInt64()
        {
            while (true)
            {
                string text = Console.ReadLine();
                Int64 number;
                if (Int64.TryParse(text, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Input isn`t correct, try again");
                }
            }
        }

        public static Int64[] ReadIntArray(int size)
        {
            while (true)
            {
                string text = Console.ReadLine();
                string[] array = text.Split(' ');
                Int64[] result = new Int64[size];

                if (array.Length != size)
                {
                    Console.WriteLine("Input isn`t correct, try again");
                    continue;
                }

                bool isCorrectParsed = true;

                for (int index = 0; index < size; index++)
                {
                    if (!Int64.TryParse(array[index], out result[index]))
                    {
                        isCorrectParsed = false;
                        break;
                    }
                }

                if (isCorrectParsed)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Input isn`t correct, try again");
                }
            }
        }
}
}
