using System;

namespace SentenciaIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            Console.WriteLine("PROGRAMA DOS DIGITOS");
            Console.WriteLine("Digite numero");
            numero=int.Parse(Console.ReadLine());
            if(numero>9){
                Console.WriteLine("El número tiene dos dígitos: " + numero);
            }else if(numero>=100){
                Console.WriteLine("El número tiene mas de dos dígitos: "+ numero);
            }else{
                Console.WriteLine("Fuera de rango");
            }
            Console.ReadKey();
            // crea un intermitente para no leer más código delante        
        }
    }
}
