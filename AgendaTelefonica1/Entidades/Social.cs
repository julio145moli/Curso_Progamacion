using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Social : Persona
    {
        public Social()
        {
        }

        public Social(string facebook)
        {
            Facebook = facebook;
        }

        public String Facebook { get; set; }
    }
}
