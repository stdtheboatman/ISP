using System;
using System.ComponentModel.DataAnnotations;

namespace FractionLab
{
    public class MyMath
    { 
        public static int Gcd(int a, int b)
        {
            while(a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a + b;
        }

        public static int Lcm(int a, int b)
        {
            return a * b / MyMath.Gcd(a, b);
        }

        public static int Abs(int a)
        {
            return a < 0 ? -a : a;
        }

        public static int Pow(int a, int n)
        {
            int result = 1;
            while (n != 0)
            {
                if (n % 2 == 1)
                {
                    result *= a;
                }

                a *= a;
                n >>= 1;
            }

            return result;
        } 
    }
}