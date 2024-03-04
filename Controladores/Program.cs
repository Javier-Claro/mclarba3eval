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

                menu.MenuVenta(opcion);
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
                        patata.mostrarVentasDia();
                        break;

                    case 4:
                        patata.crearPedidoProveedores();
                        break;

                    case 5:                        
                        Console.WriteLine("\n\tGracias, hasta luego.");
                        break;
                }

            }while (opcion != 5);
        }
    }
}