using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsSubMenu
    {

        //metodo
        static public void Submenu()
        {
            int opcion = 0;
            do
            {
                Console.Clear(); // Limpia la pantalla
                Console.WriteLine("-------------Submenu Reportes-------------");
                Console.WriteLine("Opcion 1:  Reporte Estudiantes por condicion");
                Console.WriteLine("Opcion 2:  Reporte de todos los datos");
                Console.WriteLine("Opcion 3:  Regresar al Menu Principal");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Seleccione su opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);// si ingresa una letra no va a dejar continuar
                switch (opcion)
                {
                    case 1: ClsReportes.ReporteCondicion(); break;
                    case 2: ClsEstudiante.Ingresar(); break;
                    default:
                        Console.WriteLine("Regresando...");
                        Thread.Sleep(1500);
                        Console.Clear(); // Limpia la pantalla
                        break;

                }
            } while (opcion != 3);

        }// fin metodo Submenu

    }
}
