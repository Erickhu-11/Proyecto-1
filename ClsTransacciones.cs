using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Proyecto_I_Programacion_II_Final
{
    internal class ClsTransacciones
    {
        const int Vehiculos = 15;

        static int[] NFactura = new int[Vehiculos];
        static string[] NPlaca = new string[Vehiculos];
        static string NPlacaActualizada;
        static string[] FechayHora = new string[Vehiculos];
        static string[] TVehiculo = new string[Vehiculos];
        static string TVehiculoActualizado;
        static int[] NCaseta = new int[Vehiculos];
        static int NCasetaActualizado;
        static int[] Pago = new int[Vehiculos]; 
        static int PagoActualizado;
        static int[] PagaCon = new int[Vehiculos];
        static int PagaConActualizado;
        static int[] Vuelto = new int[Vehiculos];
        static int VueltoActualizado;
        static int Total = 0;
        static int Contador = 1;


        public static void InicializaciondeValores()
        {
            Total = 0;
            for (int i = 0; i < Vehiculos; i++)
            {
                NFactura[i] = 0;
                NPlaca[i] = "";
                FechayHora[i] = "";
                TVehiculo[i] = "";
                NCaseta[i] = 0;
                Pago[i] = 0;
                PagaCon[i] = 0;
                Vuelto[i] = 0;
                Contador = 1;
            }
            Console.WriteLine("Vectores inicializados");
            Console.WriteLine("<<< Pulse cualquier tecla para continuar >>>");
            Console.ReadLine();
        }


        public static void IngresoDatos()
        {
            char continuar;
            do
            {
                Console.WriteLine("Registro de Datos del Vehículo");
                Console.WriteLine("||||||||||||||||||||||||||||||||");
                Console.Write("Numero Factura: ");
                Console.WriteLine("");
                NFactura[Total] = Contador++;
                Console.WriteLine("Numero de Placa: ");
                NPlaca[Total] = Console.ReadLine();
                DateTime fechayhoraactual = DateTime.Now;
                string FechayHoraSt = fechayhoraactual.ToString();
                FechayHora[Total] = FechayHoraSt;
                Console.WriteLine("Numero caseta: [1= Caseta 1 || 2= Caseta 2 || 3= Caseta 3]");
                NCaseta[Total] = int.Parse(Console.ReadLine());
                Console.WriteLine("Tipo de vehículo:[A= Moto || B= Vehículo Liviano || C= Camión Pesado || D= Autobús]");
                string i = "";
                i = Console.ReadLine().ToLower();
                switch (i)
                {
                    case "a":
                        TVehiculo[Total] = "Moto";
                        Console.WriteLine("El monto a pagar es de 500:");
                        Pago[Total] = 500;
                        Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                        PagaCon[Total] = int.Parse(Console.ReadLine());
                        if (PagaCon[Total] > 500)
                        {

                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("Su vuelto es de: " + Vuelto[Total]);


                        }
                        else
                        {
                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("faltan: " + Vuelto[Total]);
                        }

                        break;
                    case "b":
                        TVehiculo[Total] = "Vehículo";
                        Console.WriteLine("El monto a pagar es de 700:");
                        Pago[Total] = 700;
                        Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                        PagaCon[Total] = int.Parse(Console.ReadLine());
                        if (PagaCon[Total] > 700)
                        {

                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("Su vuelto es de: " + Vuelto[Total]);


                        }
                        else
                        {
                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("faltan: " + Vuelto[Total]);
                        }
                        break;
                    case "c":
                        TVehiculo[Total] = "Camion";
                        Console.WriteLine("El monto a pagar es de 2700:");
                        Pago[Total] = 2700;
                        Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                        PagaCon[Total] = int.Parse(Console.ReadLine());
                        if (PagaCon[Total] > 2700)
                        {

                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("Su vuelto es de: " + Vuelto[Total]);


                        }
                        else
                        {
                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("faltan: " + Vuelto[Total]);
                        }
                        break;
                    case "d":
                        TVehiculo[Total] = "Autobus";
                        Console.WriteLine("El monto a pagar es de 3700:");
                        Pago[Total] = 3700;
                        Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                        PagaCon[Total] = int.Parse(Console.ReadLine());
                        if (PagaCon[Total] > 3700)
                        {

                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("Su vuelto es de: " + Vuelto[Total]);


                        }
                        else
                        {
                            Vuelto[Total] = PagaCon[Total] - Pago[Total];
                            Console.WriteLine("faltan: " + Vuelto[Total]);
                        }
                        break;
                    default:
                        Console.WriteLine("Digite una opcion correcta!");
                        break;


                }
                Total++;
                Console.WriteLine("Desea continuar S/N");
                continuar = char.Parse(Console.ReadLine());
            }
            while (continuar == 'S' || continuar == 's');
        }

        public static void Modificar()
        {
            
            Boolean Existe = false;
            Console.WriteLine("Digite el numero de placa a modificar");
            string Nplaca = Console.ReadLine();
            for (int i = 0; i < Total; i++)
            {
                if (NPlaca[i] == Nplaca)
                {
                    Console.WriteLine("Resultados de la consultado: ");
                    Console.WriteLine("Número Factura     Placa       Tipo de Vehículo    Número Caseta     Monto a Pagar   Paga con   Vuelto");
                    Console.WriteLine("=============================================================================================================");
                    Console.WriteLine($"{NFactura[i]}                  {NPlaca[i]}              {TVehiculo[i]}                 {NCaseta[i]}               {Pago[i]}              {PagaCon[i]}          {Vuelto[i]}");
                    Existe = true;
                    Console.WriteLine("Presione para continuar");
                    Console.ReadLine();
                    Console.WriteLine("Seleccione el dato que desea modificar:");
                    Console.WriteLine("1. Número Placa");
                    Console.WriteLine("2. Tipo de Vehículo y Pago");
                    Console.WriteLine("3. Número Caseta");
                    Console.WriteLine("Ingrese una opción: ");

                    
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nuevo número de placa");
                            NPlacaActualizada = Console.ReadLine();

                            NPlaca[i] = NPlacaActualizada;
                            Console.WriteLine("El número de placa ha sido actualizada");
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadLine();


                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo tipo de vehículo y pago: ");
                            Console.WriteLine("Tipo de vehículo:[1= Moto || 2= Vehículo Liviano || 3= Camión Pesado || 4= Autobús]");
                            int a = 0;
                            a = byte.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                TVehiculoActualizado = "Moto";
                                TVehiculo[i] = TVehiculoActualizado;
                                Console.WriteLine("El monto a pagar es de 500:");
                                PagoActualizado = 500;
                                Pago[i] = PagoActualizado;
                                Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                                PagaConActualizado = int.Parse(Console.ReadLine());
                                PagaCon[i] = PagaConActualizado;
                                if (PagaCon[i] > 500)
                                {

                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("Su vuelto es de: " + Vuelto[i]);


                                }
                                else
                                {
                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("faltan: " + Vuelto[i]);
                                }

                            }
                            if (a == 2)
                            {
                                TVehiculoActualizado = "Vehículo Liviano";
                                TVehiculo[i] = TVehiculoActualizado;
                                Console.WriteLine("El monto a pagar es de 700:");
                                PagoActualizado = 700;
                                Pago[i] = PagoActualizado;
                                Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                                PagaConActualizado = int.Parse(Console.ReadLine());
                                PagaCon[i] = PagaConActualizado;
                                if (PagaCon[i] > 700)
                                {

                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("Su vuelto es de: " + Vuelto[i]);


                                }
                                else
                                {
                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("faltan: " + Vuelto[i]);
                                }
                                Console.WriteLine("El tipo de vehículo ha sido actualizado");
                                Console.WriteLine("Presione una tecla para continuar");
                                Console.ReadLine();
                            }
                            if (a == 3)
                            {
                                TVehiculoActualizado = "Camión Pesado";
                                TVehiculo[i] = TVehiculoActualizado;
                                Console.WriteLine("El monto a pagar es de 2700:");
                                PagoActualizado = 2700;
                                Pago[i] = PagoActualizado;
                                Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                                PagaConActualizado = int.Parse(Console.ReadLine());
                                PagaCon[i] = PagaConActualizado;
                                if (PagaCon[i] > 2700)
                                {

                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("Su vuelto es de: " + Vuelto[i]);


                                }
                                else
                                {
                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("faltan: " + Vuelto[i]);
                                }
                                Console.WriteLine("El tipo de vehículo ha sido actualizado");
                                Console.WriteLine("Presione una tecla para continuar");
                                Console.ReadLine();
                            }
                            if (a == 4)
                            {
                                TVehiculoActualizado = "Autobús";
                                TVehiculo[i] = TVehiculoActualizado;
                                Console.WriteLine("El monto a pagar es de 3700:");
                                PagoActualizado = 3700;
                                Pago[i] = PagoActualizado;
                                Console.WriteLine("Ingrese el monto con el que desea pagar: ");
                                PagaConActualizado = int.Parse(Console.ReadLine());
                                PagaCon[i] = PagaConActualizado;
                                if (PagaCon[i] > 3700)
                                {

                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("Su vuelto es de: " + Vuelto[i]);


                                }
                                else
                                {
                                    VueltoActualizado = PagaCon[i] - Pago[i];
                                    Vuelto[i] = VueltoActualizado;
                                    Console.WriteLine("faltan: " + Vuelto[i]);
                                }
                                Console.WriteLine("El tipo de vehículo ha sido actualizado");
                                Console.WriteLine("Presione una tecla para continuar");
                                Console.ReadLine();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo número de caseta");
                            Console.WriteLine("Numero caseta: [1= Caseta 1 || 2= Caseta 2 || 3= Caseta 3]");
                            NCasetaActualizado = int.Parse(Console.ReadLine());
                            NCaseta[i] = NCasetaActualizado;
                            Console.WriteLine("El número de caseta ha sido actualizada");
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("No se realizó ninguna modificación");
                            Console.ReadLine();
                                break;
                    }

                }
            }

            if (Existe == false)
            {
                Console.WriteLine("El número de placa consultado no existe, por favor ingrese uno corecto");
            }
            
            
        }

        public static void Consulta()
        {
            Boolean Existe = false;
            Console.WriteLine("Digite el numero de placa a consultar");
            string Nplaca = Console.ReadLine();
            for (int i = 0; i < Total; i++)
            {
                if (NPlaca[i] == Nplaca)
                {
                    Console.WriteLine("Resultados de la consultado: ");
                    Console.WriteLine("Número Factura     Placa       Tipo de Vehículo    Número Caseta     Monto a Pagar   Paga con Vuelto   Vuelto");
                    Console.WriteLine("=============================================================================================================");
                    Console.WriteLine($"{NFactura[i]}                  {NPlaca[i]}              {TVehiculo[i]}                 {NCaseta[i]}               {Pago[i]}              {PagaCon[i]}          {Vuelto[i]}");
                    Existe = true;
                    Console.ReadLine();

                }
            }

            if (Existe == false)
            {
                Console.WriteLine("El número de placa consultado no existe, por favor ingrese uno corecto");
            }
            Console.ReadLine();


        }

        public static void Reporte()
        {
            {
                int SumaPago = Pago.Sum();
                Console.WriteLine("Reporte");
                Console.WriteLine("Numero de factura    Placa    Fecha y Hora   Tipo de vehículo    Caseta  Monto Pagar     Paga con     Vuelto");
                Console.WriteLine("==============================================================================================================");

                for (int i = 0; i < Vehiculos; i++)
                {
                    Console.WriteLine($"{NFactura[i]}                   {NPlaca[i]}    {FechayHora[i]}        {TVehiculo[i]}            {NCaseta[i]}        {Pago[i]}           {PagaCon[i]}          {Vuelto[i]}");
                }
                
                Console.WriteLine("==============================================================================================================");
                Console.WriteLine($"Cantidad de vehículos: {Total}   total: {SumaPago}");
                Console.WriteLine("==============================================================================================================");
                Console.WriteLine("<<< Pulse cualquier tecla para regresar >>>");
                Console.ReadKey();
            }
        }
    }
}
