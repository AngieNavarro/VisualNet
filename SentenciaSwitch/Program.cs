using System;

namespace SentenciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentencia Switch");
            /*
            Enunciado
            Ingresar un valor entre 1 y 5, luego mostrar en español el valor ingresado.
            Si se ingresa un valor fuera del rango mostrat un mensaje               
             */
            int valor=0;
            Console.WriteLine("Digitar Valor");
            valor=int.Parse(Console.ReadLine());
            
            switch (valor)
            {
                case 1:
                Console.WriteLine("UNO");
                break;
                case 2:
                Console.WriteLine("DOS");
                break;
                case 3:
                Console.WriteLine("TRES");
                break;
                case 4:
                Console.WriteLine("CUARTA");
                break;
                case 5:
                Console.WriteLine("QUINTA");
                break;
                default:
                Console.WriteLine("FUERA DE RANGO");
                break;
            }
              Console.ReadKey();
        }
    }
}
