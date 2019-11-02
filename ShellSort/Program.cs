using System;

namespace Shell {
    public class ShellSort {
        public void sort (int[] list) {
            int j, inc;
            inc = list.Length / 2;
            while (inc >= 1) {
                for (int i = inc; i < list.Length; i++) {
                    int v = list[i];
                    j = i - inc;
                    while (j >= 0 && list[j] > v) {
                        list[j + inc] = list[j];
                        j = j - inc;
                    }
                    list[j + inc] = v;
                }
                inc = inc / 2;
            }
        }
    }
    class Program {
        static void Main (string[] args) {
            int n;
            int h;
            int[] vector;
            Console.WriteLine ("Metodo de Ordenamiento ShellSort");
            Console.WriteLine ("Ingrese longitud del arreglo N: ");
            n = Int32.Parse (Console.ReadLine ());
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++) {
                Console.WriteLine ("Ingrese valor{0}: ", i + 1);
                vector[i] = Int32.Parse (Console.ReadLine ());
            }
            ShellSort sh = new ShellSort ();
            sh.sort (vector);
            Console.WriteLine ("Numeros Ordenados por el Metodo ShellSort");
            for (int i = 0; i < h; i++) {
                Console.Write (vector[i] + "-");
            }
            Console.ReadLine ();

        }
    }
}