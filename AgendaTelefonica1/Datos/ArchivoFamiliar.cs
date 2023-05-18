using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using System.Web;

namespace Datos     
{
    public class ArchivoFamiliar
    {
        string ruta = "contacto.txt";
        public string GuardarContanto(Familiar  contacto)
        {
           
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(contacto.ToString());
                    
            sw.Close();
            return "ok";
        }
    }
}
