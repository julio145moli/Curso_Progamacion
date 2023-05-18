using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresarial : Persona
    {
        public Empresarial()
        {
        }

        public Empresarial(string nombreEmpresa, string sector, string correoEmpresa)
        {
            NombreEmpresa = nombreEmpresa;
            Sector = sector;
            CorreoEmpresa = correoEmpresa;
        }

    

        public String NombreEmpresa { get; set; }
        public String Sector { get; set; }
        public String CorreoEmpresa { get; set; }

    }
}
