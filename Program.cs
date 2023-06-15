using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_I_Programacion_II_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.WriteLine("A-Inicializar vectores");
                Console.WriteLine("B-Ingresar paso vehicular");
                Console.WriteLine("C-Consulta de vehículos x número de placa");
                Console.WriteLine("D-Modificar datos vehículos x número de placa");
                Console.WriteLine("E-Reporte todos los datos de los vectores");
                Console.WriteLine("F-Salir");
                Console.Write("Digite una opcion:");
                op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "a": ClsTransacciones.InicializaciondeValores(); break;
                    case "b": ClsTransacciones.IngresoDatos(); break;
                    case "c": ClsTransacciones.Consulta(); break;
                    case "d": ClsTransacciones.Modificar(); break;
                    case "e": ClsTransacciones.Reporte(); break;
                    case "f": break;
                    default:
                        Console.WriteLine("Digite una opción valida");
                        break;
                }

            } while (!op.Equals("f"));


            Console.ReadLine();

        }
    }
}

