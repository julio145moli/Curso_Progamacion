using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoEmpresarial: Persona
    {
        public ContactoEmpresarial() { }
        public string nit { get; set; }
        public string nombte { get; set; }
        public string correo { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
