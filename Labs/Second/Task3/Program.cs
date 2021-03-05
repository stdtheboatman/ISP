using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace task3
{
    class Program
    {
        static Int64 Solve(Int64 r)
        {
            Int64 result = 0;
            while(r != 0)
            {
                result += r / 2;
                r /= 2;
            }

            return result;
        }

        static Int64 Solve(Int64 a, Int64 b)
        {
            return Solve(b) - Solve(a - 1);
        }

        static Int64 BruteSolve(Int64 a, Int64 b)
        {
            BigInteger number = new BigInteger(1);
            for(Int64 i = a; i <= b; i++)
            {
                number *= i;
            }

            Int64 result = 0;
            while(number % 2 == 0)
            {
                result++;
                number /= 2;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Int64[] input = Reader.ReadIntArray(2);

            Int64 a = input[0];
            Int64 b = input[1];

            if (a > b)
            {
                Int64 temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine(Solve(a, b));
            Console.WriteLine(BruteSolve(a, b));
        }
    }
}
