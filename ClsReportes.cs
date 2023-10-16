using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsReportes
    {
        static string condicion;
        public static void ReporteCondicion()
        {
            Console.WriteLine("Reporte Estudiantes por Condición: " + condicion);
            Console.WriteLine("Cedula\t\tNombre\t\tPromedio\tCondición");
            Console.WriteLine("=========================================================================");


            Console.WriteLine("=========================================================================");
            Console.WriteLine("\t\t <PULSE CUALQUIER TECLA PARA ABANDONAR>");
            Console.ReadKey();
        }// fin metodo reporte condicion

        public static void ReporteTotal()
        { 
        
        
        }//fin metodo Reporte toal



    }//fin clase
}// fin namespace
