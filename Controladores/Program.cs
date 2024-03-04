using Mclarba3eval.Servicios;
using Mclarba3eval.Dtos;
using System;

namespace Mclarba3eval.Controladores
{
    class Program
    {
        /// <summary>
        /// Clase Main del programa
        /// 04/03/2024 - mjcb
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                MenuIntz menu = new MenuImpl();

                OperativaIntfz patata = new OperativaImpl();

                menu.MenuPrincipal(opcion);
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        menu.MenuGerencia(opcion);
                        Console.Clear();
                        switch (opcion)
                        {
                            case 1:
                                patata.añadirVenta();
                                break;

                            case 2:
                                patata.calculoTotalVentasDia();
                                break;

                            case 3:
                                Console.WriteLine("\n\tMuchas gracias, hasta luego.");
                                break;
                        }
                        break;

                    case 2:
                        menu.MenuEmpleado(opcion);

                        switch (opcion)
                        {
                            case 1:
                                patata.mostrarVentasDia();
                                break;

                            case 2:
                                patata.crearPedidoProveedores();
                                break;

                            case 3:
                                Console.WriteLine("\n\tMuchas gracias, hasta luego.");
                                break;
                        }
                        break;                 
                }
            }while (opcion != 3);
        }
    }
}