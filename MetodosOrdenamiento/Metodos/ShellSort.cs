using System;
namespace MetodosOrdenamiento {
    class ShellSort {
        int h;
        int[] vector;
        public ShellSort (int n) {
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++) {
                Console.WriteLine ("Ingrese valor{0}: ", i + 1);
                vector[i] = Int32.Parse (Console.ReadLine ());
            }
            sort (vector);
            mostrar ();
        }

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
        private void mostrar () {
            Console.WriteLine ("Numeros Ordenados por el Metodo ShellSort");
            for (int i = 0; i < h; i++) {
                Console.Write (vector[i] + "-");
            }
            Console.ReadLine ();
        }
    }

}