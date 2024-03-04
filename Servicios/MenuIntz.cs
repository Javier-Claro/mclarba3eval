using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mclarba3eval.Servicios
{
    internal interface MenuIntz
    {
        public int MenuPrincipal(int opcion);

        public int MenuEmpleado(int opcion);

        public int MenuGerencia(int opcion);
    }
}
