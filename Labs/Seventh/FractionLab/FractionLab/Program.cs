using System;

namespace FractionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 4);
            Fraction b = new Fraction("0.25");
            Fraction c = new Fraction("1/2/2");
            
            Console.WriteLine("a: " + a);
            Console.WriteLine("a: " + b);
            Console.WriteLine("a: " + c);
            
            Console.WriteLine($"a == b, a == c, b == c? {a == b}, {a == c}, {b == c}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            a = new Fraction("1/2");
            b = new Fraction("1/4");

            Console.WriteLine("a: " + a);
            Console.WriteLine("a: " + b);

            
            Console.WriteLine($"a < b? {a < b}");
            Console.WriteLine($"a > b? {a > b}");
            Console.WriteLine($"a <= b? {a <= b}");
            Console.WriteLine($"a >= b? {a >= b}");
            Console.WriteLine($"a == b? {a == b}");
            Console.WriteLine("\n\n");
            
            
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a * b = {a * b}");
            
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            c = new Fraction("1/fsd");
            Console.WriteLine("c: " + c);
            
            c = new Fraction("4");
            Console.WriteLine("c: " + c);
            
            c = new Fraction("1/0");
            Console.WriteLine("c: " + c);
            
            Console.WriteLine("\n\n\n");
            
            Console.WriteLine("a to double {0:Double}", a);
            Console.WriteLine("a to double: " +  (double)a);
            Console.WriteLine("a to int {0:Int}", a);
            Console.WriteLine("a to int: " +  (int)a);
            Console.WriteLine("a to std {0:Std}", a);
            Console.WriteLine("a to std " + a);
            
            Console.WriteLine("\n\n");
            a += (Fraction)4;
            
            Console.WriteLine("a to double {0:Double}", a);
            Console.WriteLine("a to double: " +  (double)a);
            Console.WriteLine("a to int {0:Int}", a);
            Console.WriteLine("a to int: " +  (int)a);
            Console.WriteLine("a to std {0:Std}", a);
            Console.WriteLine("a to std " + a);

        }
    }
}
