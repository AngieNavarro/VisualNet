using System;

namespace SentenciaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentencia For");
            
            /*
            Enunciado
            Describir un programa que lea 5 notas de alumnos y nos informe cuantos tiene notas
            mayores e iguales a 7 y cuantos menores.
             */
            int aprobado=0, reprobado=0, c=0, nota=0;
            Console.WriteLine("Programa notas estudiantes");
            for ( c = 1; c <=5; c++)
            {
                Console.WriteLine("Digite Nota:");
                nota=int.Parse(Console.ReadLine());
                if(nota<=3){
                    reprobado++;
                }else{
                    aprobado++;
                }

            }
            Console.WriteLine("Aprobados: "+aprobado);
            Console.WriteLine("Reprobados: "+reprobado);
            
            Console.ReadKey();



        }
    }
}
