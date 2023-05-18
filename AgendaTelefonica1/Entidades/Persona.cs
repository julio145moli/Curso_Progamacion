using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }

        public Persona()
        {

        }

        public Persona(int id, string nombre, string apellido, string telefono)
        {
            this.id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }

        }
}
