using System;

namespace Empleado
{
    class Empleado
    {       //ATRIBUTOS
            int cedula=0;
            String nombres="";
            //CONSTRUCTOR VACIO

            public Empleado(){

            }
            public Empleado(int cedula, String nombre){
                this.cedula=cedula;
                this.nombres=nombre;
            }
            //Metodos getter y setter 
            public int Cedula{
                get{return cedula;}
                set{cedula=value;}
            }
            public String Nombre{
                get{return nombres;}
                set{nombres=value;}
            }
            //metodos transaccionales
        static void Main(string[] args)
        {
            //instancia de una clase 
            Empleado empleado= new Empleado(123,"Angie Navarro");
            Empleado empleado1=new Empleado(234,"Edwin Espitia");
            Console.WriteLine(empleado.nombres);
            Console.WriteLine(empleado.cedula);
            Console.WriteLine(empleado1.nombres);
            Console.WriteLine(empleado1.cedula);
            Console.ReadKey();

            

        }
    }
}
