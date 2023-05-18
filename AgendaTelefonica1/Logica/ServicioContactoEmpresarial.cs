using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoEmpresarial : IservicioContacto<Empresarial>
    {

        List<Empresarial> contactoEmpresarials = null;

        public ServicioContactoEmpresarial()
        {
            contactoEmpresarials = new List<Empresarial>();
        }
        public string Add(Empresarial contacto)
        {
            try
            {
                //validar
                if (contacto == null)
                {
                    return "error al guardar el contacto EMPRESARIAL ";
                }

                contactoEmpresarials.Add(contacto);
                return $"se guardo el contacto EMPRESARIAL --> {contacto.Nombre}";
            }
            catch (Exception)
            {
                return "error al guardar el contacto EMPRESARIAL ";
            }
        }

        public string Delete(Empresarial contacto)
        {
            throw new NotImplementedException();
        }

        public bool exists(Empresarial contacto)
        {
            throw new NotImplementedException();
        }

        public List<Empresarial> GetAll()
        {
            if (contactoEmpresarials.Count == 0) { return null; }

            return contactoEmpresarials;
        }

        public List<Empresarial> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Empresarial GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public string Update(Empresarial contacto)
        {
            throw new NotImplementedException();
        }
    }
}
