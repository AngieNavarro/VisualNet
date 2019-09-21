using System;

namespace Universidad.Entidades {
    public class Sede {
        // Atributos
        string nombre;
        int añoCreacion;
        string ciudad;

        // Metodo Constructor
        public Sede () {
            // Constructor vacio
        }

        public Sede (string nombre, int añoCreacion, string ciudad) {
            this.nombre = nombre;
            this.añoCreacion = añoCreacion;
            this.ciudad = ciudad;
        }
        //public Sede(string nombre,int añoCreacion)=>(Nombre,AñoCreacion)=(nombre,añoCreacion);-->Declaracion de constructor

        // Metodo Get y Set
        //public int AñoCreacion {  get; set; }
        public string Ciudad {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public int AñoCreacion {
            get { return añoCreacion; }
            set { añoCreacion = value; }
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        // Metodos Transaccionales CRUD
        public void Mostrar () {
            Console.WriteLine ("Nombre de la Sede: " + Nombre);
            Console.WriteLine ("El año de creación es: " + AñoCreacion);
            Console.WriteLine ("Ciudad: " + Ciudad);

        }

    }

}