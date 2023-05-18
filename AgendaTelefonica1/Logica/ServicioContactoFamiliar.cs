using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class ServicioContactoFamiliar : IservicioContacto<Familiar>

    {
        List<Familiar> contactoFamiliars = null;

        public ServicioContactoFamiliar()
        {
            contactoFamiliars = new List<Familiar>();
        }

        public string Add(Familiar contacto)
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

        public string Delete(Familiar contacto)
        {
            throw new NotImplementedException();
        }

        public bool exists(Familiar contacto)
        {
            throw new NotImplementedException();
        }

        public List<Familiar> GetAll()
        {
            if (contactoFamiliars.Count == 0) { return null; }

            return contactoFamiliars;
        }

        public List<Familiar> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Familiar GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public string Update(Familiar contacto)
        {
            throw new NotImplementedException();
        }
    }
}
