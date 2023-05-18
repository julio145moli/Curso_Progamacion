using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class ServicioContacto
    {
        public string GuardarContacto()
        {
            Archivo archivo = new Archivo();
            var msg = archivo.Guardar();
            
            return msg;
        }
    }
}
