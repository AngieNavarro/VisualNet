using System;

namespace Ejercicio_For_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio");
            /*
            Enunciado
            Crear un vector de n elementos de tipo decimal. 
            Mostrar cuantos elementos son superiores a 500. 
             */
            float[] n=new float[5]; 
            int cont=0;
            for (int i = 0; i <5; i++)
            {
             Console.WriteLine("Digite números: ");
             n[i] =float.Parse(Console.ReadLine());   
            }
            foreach (var item in n)
            {
                if(item > 500){
                    cont++;
                }
            }
            Console.WriteLine("La cantidad es: "+ cont);
            Console.ReadKey();
            
        }
    }
}
