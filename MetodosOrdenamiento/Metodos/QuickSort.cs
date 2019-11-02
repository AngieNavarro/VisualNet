using System;
namespace MetodosOrdenamiento {
    class QuickSort {
        int h;
        int[] vector;
        public QuickSort (int n) {
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++) {
                Console.WriteLine ("Ingrese valor{0}: ", i + 1);
                vector[i] = Int32.Parse (Console.ReadLine ());
            }
            quickSort (vector, 0, h - 1);
            mostrar ();
        }
        private void quickSort (int[] vector, int primero, int ultimo) {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j) {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;

                }
            } while (i <= j);
            if (primero < j) {
                quickSort (vector, primero, j);
            }
            if (i < ultimo) {
                quickSort (vector, i, ultimo);
            }
        }
        private void mostrar () {
            Console.WriteLine ("Numeros Ordenados por el Metodo QuickSort");
            for (int i = 0; i < h; i++) {
                Console.Write (vector[i] + "-");
            }
            Console.ReadLine ();
        }
    }
}