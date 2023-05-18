using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchivoFamiliar archivo = new ArchivoFamiliar();

            var msg =archivo.GuardarContanto(new Familiar(1,"abc","kfhjaldf","9991",DateTime.Now));
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
