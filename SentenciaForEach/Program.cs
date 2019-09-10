using System;

namespace SentenciaForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentenica For Each");
            /*
            Enunciado
            Almacenar los 
             */
            int[] sueldos=new int[5];
            for(int c=0; c<5; c++){
                Console.WriteLine("Ingresar Valor");
                sueldos[c]=int.Parse(Console.ReadLine());
            }
            foreach (var sueldo in sueldos)
            {
                Console.WriteLine("El sueldo es: "+sueldo);
            }
            Console.ReadKey();
        }
    }
}
