using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double a, b, c,x1,x2;
            Console.WriteLine("a?");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b?");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c?");
            c = double.Parse(Console.ReadLine());
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Console.WriteLine("X1 " + x1.ToString("N2"));
            Console.WriteLine("X2 " + x2.ToString("N2"));
            Console.ReadKey();
        }
    }
}
