using System;

namespace Ejercicio_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
         /*
            Enunciado
            Ingresar un valor entre 1 y 5, en letra y  luego mostrar el numero del valor ingresado.
            Si se ingresa un valor fuera del rango mostrat un mensaje               
             */
            String valor="";
            Console.WriteLine("Digitar Valor");
            valor=(Console.ReadLine());
            
            switch (valor.ToUpper())
            {
                case "UNO":
                Console.WriteLine(1);
                break;
                case "DOS":
                Console.WriteLine(2);
                break;
                case "TRES":
                Console.WriteLine(3);
                break;
                case "CUATRO":
                Console.WriteLine(4);
                break;
                case "CINCO":
                Console.WriteLine(5);
                break;
                default:
                Console.WriteLine("FUERA DE RANGO");
                break;
            }
              Console.ReadKey();
        }
    }
}

