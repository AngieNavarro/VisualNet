using System;

namespace SentenciaTry_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentencia Try-Catch-Finally");
            /*
            Enunciado
            Controlar y mostrar el error que captura el catch cuando se intenta dividir por cero, 
            imprimir la propiedad Stack trace de la excepción 
             */
            int numero=0, division=0;
            Console.WriteLine("Digite numero ");
            numero=int.Parse(Console.ReadLine());
            try
            {
                division=numero/0;
            }
            catch (Exception error)
            {
                Console.WriteLine("El error es: "+ error.Message);
               
            }
            
        }
    }
}
