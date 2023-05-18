using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("HOLA MUNDO");
            //Console.ReadKey();

            ServicioContacto servicio = new ServicioContacto();
            var msg = servicio.GuardarContacto("PEDRO");
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
