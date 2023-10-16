using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsProfesor
    {
        /*
         * Delimitadores de acceso public, private, protected
        public: se puede ver en cualquier parte del programa o clase
        private: cuando es privado solo se ve en la clase donde se crea el metodo
        static: le pertenecen siempre a la clase
        */

        //Atributos clase profesor

        public string cedula { get; set; }
        public string nombre { get; set; }
        public float salario { get; set; }

        public static float precio = 300;
        // constructor sirve para definir como voy crear mi clase
        public ClsProfesor(string Cedula, string Nombre, float Salario)
        {
            this.cedula = Cedula;// this significa que la variable que sigue es global
            this.nombre = Nombre;
            this.salario = Salario;
        }
        public ClsProfesor(String Cedula)
        {
            this.cedula = Cedula;
        }
        
        public ClsProfesor() 
        { 
        }


        //metodo 
        public void Imprimir() 
        {
            Console.WriteLine(cedula);

        }// fin metodo Imprimir
    }
}
