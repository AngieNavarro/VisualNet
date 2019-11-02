using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma;
            Console.WriteLine("Digite numero 1");
            numero1=int.Parse(Console.ReadLine());  
             Console.WriteLine("Digite numero 2");
            numero2=int.Parse(Console.ReadLine());
            Console.WriteLine("Suma!");
            suma=numero1+numero2;
            Console.WriteLine(suma);
        }
    }
}
