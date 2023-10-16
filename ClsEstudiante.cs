using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsEstudiante
    {
         static string condicion = "";// var global para utilizar en ingreso, consulta y modificar

        // atributos de estudiantes
        public static int cantidad = 1;
		static public string [] cedula = new string[cantidad];
        static public string [] nombre = new string[cantidad];
        static public int [] promedio = new int[cantidad];
        
		// Constructor
		public ClsEstudiante()
		{

		}
        // metodos
        public static void Inicializar()
        {
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            promedio = Enumerable.Repeat(20, cantidad).ToArray();

            Console.WriteLine("Cargando Vectores al programa.");
            Console.WriteLine("Por favor espere...");
            // Limpia la pantalla después de 2 segundos
            Thread.Sleep(2000); // Espera 2 segundos (2500 milisegundos)
            Console.WriteLine("Vectores inicializados con exito.\n");
            Thread.Sleep(1500);
            Console.Clear(); // Limpia la pantalla
            
        }// fin incializar

        public static void Ingresar()
        {
			int cant = 1;
			for (int i = 0; i < cantidad; i++)
			{
				Console.WriteLine("Digite el número de cedula {0}:", cant);
				cedula[i] = Console.ReadLine();
				Console.WriteLine("Digite el nombre del estudiante {0}:", cant);
				nombre[i] = Console.ReadLine();
				Console.WriteLine("Digite el promedio del estudiante {0}:", cant);
				int.TryParse(Console.ReadLine(), out promedio[i]);
                Console.WriteLine($"\nEstudiante {cant} agregado correctamente.\n"); // Agregamos el número del estudiante a la salida
                cant++;
                
            }//fin for
        }// fin metodo Ingresar
        public static string ObtenerCondicion(int promedio)
        {
            if (promedio >= 70)
            {
                return "Aprobado";
            }
            else if (promedio >= 60)
            {
                return "Reprobado";
            }
            else
            {
                return "Aplazado";
            }
        }
        public static void Consultar(string id)// metodo consultar con parametro id
		{
			int indiceEncontrado = -1; // Inicializamos con un valor que indica que no se encontró el estudiante
            for (int i = 0; i < cantidad; i++)
			{
				if (id.Equals(cedula[i]))
				{
					indiceEncontrado = i;
					break; // Salimos del bucle una vez que se ha encontrado el estudiante.
				}
			}
			if (indiceEncontrado != -1)
			{
                Console.WriteLine("Datos del estudiante:");
                Console.WriteLine($"Nombre: {nombre[indiceEncontrado]}");
                Console.WriteLine($"Promedio: {promedio[indiceEncontrado]}");
                Console.WriteLine($"Condicion: {ObtenerCondicion(promedio[indiceEncontrado])}");
            }
            else
			{
                Console.WriteLine("Estudiante no encontrado.");
            }
		}// fin metodo Consultar
		
		public static string Buscar()
		{
			string ced = "";
			Console.Write("Digite el número de cedula: ");
			ced = Console.ReadLine();
			return ced;
		}// fin metodo Buscar
		
		public static void Modificar(string id)
		{
			for (int i = 0; i < cantidad; i++)
			{
				if (id.Equals(cedula[i]))
				{
					Console.Write("Digite el nuevo nombre: ");
					nombre[i] = Console.ReadLine();
					Console.Write("Digite el nuevo promedio: ");
					int.TryParse(Console.ReadLine(), out promedio[i]);
                    Console.WriteLine("\nSe han modificado los datos con exito.\n");
                    break;
                }
            }
        }// fin metodo Modificar

        public static void Eliminar(string id)
        {
            int estudianteEncontrado = -1;
            /* se inicializa en -1 ya que el array inicia en posicion cero 0 por ende aun no encuentra el ID de cedula
            cuando ya recorra el for suma +1 entrando en cero, y asi suscesivamente hasta encontrar donde se encuentre el id correcto */

            for (int i = 0; i < cantidad; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    estudianteEncontrado = i;
                    break; // Salimos del bucle una vez que se ha encontrado el estudiante a eliminar.
                }
            }

            if (estudianteEncontrado != -1)
                /* Si es diferente de -1, significa que se ha encontrado un estudiante 
                 * con la cédula proporcionada, 
                 * y por lo tanto, el bloque de código dentro del if se ejecutará.*/
            {
                for (int i = estudianteEncontrado; i < cantidad - 1; i++)
                {
                    cedula[i] = cedula[i + 1];
                    nombre[i] = nombre[i + 1];
                    promedio[i] = promedio[i + 1];
                    
                }
                // Limpiamos los datos del último estudiante que quedó duplicado
                cedula[cantidad - 1] = "";
                nombre[cantidad - 1] = "";
                promedio[cantidad - 1] = 0;

                cantidad--; // Reducimos el contador de estudiantes
                Console.WriteLine("Estudiante eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }// fin metodo Modificar

    }// fin clase internal
}// fin namespace
