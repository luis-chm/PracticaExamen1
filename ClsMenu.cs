using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsMenu
    {
        static int opcion = 0; //atributo var global

        //metodo
        static public void Desplegar()
        {

            do
            {
                Console.WriteLine("\t   Practica Examen 1 \t\n");
                Console.WriteLine("-------------Menu Principal-------------");
                Console.WriteLine("Opcion 1:  Inicializar arreglos");
				Console.WriteLine("Opcion 2:  Incluir Estudiantes");
                Console.WriteLine("Opcion 3:  Consultar Estudiante");
                Console.WriteLine("Opcion 4:  Modificar Estudiantes");
				Console.WriteLine("Opcion 5:  Eliminar Estudiantes");
                Console.WriteLine("Opcion 6:  SubMenu Reporte");
                Console.WriteLine("Opcion 7:  Salir");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Seleccione su opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);// si ingresa una letra no va a dejar continuar
                switch (opcion)
                {
                    case 1: ClsEstudiante.Inicializar(); break;
					case 2: ClsEstudiante.Ingresar(); break;
                    case 3: ClsEstudiante.Consultar(ClsEstudiante.Buscar()); break;
                    case 4: ClsEstudiante.Modificar(ClsEstudiante.Buscar()); break;
					case 5: ClsEstudiante.Eliminar(ClsEstudiante.Buscar()); break;
                    case 6: ClsSubMenu.Submenu(); break;
                    default:
                        Console.WriteLine("¡Hasta pronto!");
                        break;
                        
                }
            } while (opcion!=7);



        }// fin metodo Desplegar

    }
}
