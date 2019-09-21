using System;
using Universidad.Entidades;
namespace Universidad {
    class Program {
        static void Main (string[] args) {
            //instanciar el objeto
            Sede sede1 = new Sede ("UPA - Villa del Rosario", 2006, "Ciudad");
            /*Console.WriteLine(sede1.Nombre);
            Console.WriteLine(sede1.AñoCreacion);*/
            sede1.Mostrar ();
            Console.ReadKey ();

        }
    }
}