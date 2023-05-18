using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResponseContactoFamiliar
    {
        public bool Estado { get; set; }
        public string msg { get; set; }
        public List<ContactoFamiliar> lista { get; set; }

        public ContactoFamiliar familiar { get; set; }

    }
}
