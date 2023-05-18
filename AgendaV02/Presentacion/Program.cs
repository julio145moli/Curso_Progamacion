using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
          MenuPrincipal menu = new MenuPrincipal();
            menu.MostrarAgenda(15, 5);
        }
    }
}
