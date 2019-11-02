using System;
using MetodosOrdenamiento.Metodos;

namespace MetodosOrdenamiento {
    class Program {
        static void Main (string[] args) {
            int n, metodo;
            Console.WriteLine ("Presentado por: Angie Navarro");
            Console.WriteLine ("Metodos de Ordenamiento");
            Console.WriteLine ("Ingrese longitud del arreglo N :");
            n = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("1 -- MergeSort ");
            Console.WriteLine ("2 -- QuickSort ");
            Console.WriteLine ("3 -- ShellSort ");
            Console.WriteLine ("Ingrese el metodo de Ordenamiento :");
            metodo = Int32.Parse (Console.ReadLine ());
            switch (metodo) {
                case 1:
                    MergeSort m = new MergeSort (n);

                    break;
                case 2:
                    QuickSort q = new QuickSort (n);

                    break;

                case 3:
                    ShellSort s = new ShellSort (n);

                    break;

                default:
                    Console.WriteLine ("No hay mas metodos de Ordenamiento :");

                    break;
            }

        }
    }
}