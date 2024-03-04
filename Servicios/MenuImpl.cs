using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mclarba3eval.Servicios
{
    internal class MenuImpl : MenuIntz
    {
        /// <summary>
        /// Método donde estará el menu para acceder al elenco de opciones:
        /// 04/03/2024 - mjcb
        /// </summary>
        /// <param name="opcion"></param>
        /// <returns>La opción deseada del menú</returns>
        public int MenuVenta(int opcion)
        {
            do { 
            Console.WriteLine("-------------1. Añadir venta.");
            Console.WriteLine("-------------2. Cálculo total de ventas diario.");
            Console.WriteLine("-------------3. Mostrar ventas del día.");
            Console.WriteLine("-------------4. Crear pedido para proveedores.");
            Console.WriteLine("-------------5. Salir.");
            Console.Write("\n-------------Selecciona una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("\n\tLa opción seleccionada no existe.");
                }
            }while (opcion<1 || opcion>5);

            return opcion;
        }
    }
}
