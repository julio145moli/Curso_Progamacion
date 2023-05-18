using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoFamiliar : IContacto
    {
        List<ContactoFamiliar> contactoFamiliars= null;
        public ServicioContactoFamiliar()
        {
            contactoFamiliars = new List<ContactoFamiliar>();
        }

        public string Add(ContactoFamiliar contacto)
        {
            try
            {
                //validar
                if (contacto == null)
                {
                    return "error al guardar el contacto ";
                }
               
                contactoFamiliars.Add(contacto);
                return $"se guardo el contacto --> {contacto.Nombre}";
            }
            catch (Exception)
            {
                return "error al guardar el contacto ";
            }
           

        }

        public string Delete(ContactoFamiliar contacto)
        {
            throw new NotImplementedException();
        }

        public bool exists(ContactoFamiliar contacto)
        {
            throw new NotImplementedException();
        }

        public List<ContactoFamiliar> GetAll()
        {
           if (contactoFamiliars.Count == 0) { return null; }
           
            return contactoFamiliars;
        }

        public List<ContactoFamiliar> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public ContactoFamiliar GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public string Update(ContactoFamiliar contacto)
        {
            throw new NotImplementedException();
        }
    }
}
