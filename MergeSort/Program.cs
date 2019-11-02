using System;

namespace MergeSort {
    class Class1 {
        static void Main () {
            int n;
            Console.WriteLine("Metodo de Ordenamiento MergeSort");
            Console.WriteLine ("Ingrese longitud del arreglo N :");
            n = Int32.Parse (Console.ReadLine ());
            Cllenar b = new Cllenar (n);
        }
    }
    class Cllenar {
        int h;
        int[] vectorA;
        int[] vectorB;
        public Cllenar (int n) {
            h = n;
            vectorA = new int[h];
            vectorB = new int[h];
            for (int i = 0; i < h; i++) {
                Console.WriteLine ("ingrese valor{0}: ", i + 1);
                vectorA[i] = Int32.Parse (Console.ReadLine ());
            }
            merge_sort (0, h - 1, vectorA, vectorB);
            mostrar ();
        }
        public void merge_sort (int left, int right, int[] vectorA, int[] vectorB) {
            int mid;
            if (right > left) {
                mid = (right + left) / 2;
                merge_sort (left, mid, vectorA, vectorB);
                merge_sort (mid + 1, right, vectorA, vectorB);
                merge (left, mid + 1, right);

            }
        }
        public void merge (int left, int mid, int right) {
            int i, left_end, num_elements, tmp_pos;
            left_end = mid - 1;
            tmp_pos = left;
            num_elements = right - left + 1;
            while ((left <= left_end) && (mid <= right)) {
                if (vectorA[left] <= vectorA[mid]) {
                    vectorB[tmp_pos] = vectorA[left];
                    tmp_pos = tmp_pos + 1;
                    left = left + 1;

                } else {
                    vectorB[tmp_pos] = vectorA[mid];
                    tmp_pos = tmp_pos + 1;
                    mid = mid + 1;

                }
            }
            while (left <= left_end) {
                vectorB[tmp_pos] = vectorA[left];
                left = left + 1;
                tmp_pos = tmp_pos + 1;
            }
            while (mid <= right) {
                vectorB[tmp_pos] = vectorA[mid];
                mid = mid + 1;
                tmp_pos = tmp_pos + 1;
            }
            for (i = 0; i < num_elements; i++) {
                vectorA[right] = vectorB[right];
                right = right - 1;

            }
        }
        private void mostrar () {
            Console.WriteLine ("Numeros Ordenados por el Metodo MergeSort");
            for (int i = 0; i < h; i++) {
                Console.Write (vectorA[i] + "-");
            }
            Console.ReadLine ();
        }
    }
}