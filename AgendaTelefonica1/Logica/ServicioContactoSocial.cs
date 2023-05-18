using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoSocial : IservicioContacto<Social>
    {
        List<Social> contactoSocial = null;

        public ServicioContactoSocial()
        {
            contactoSocial = new List<Social>();

        }

        public string Add(Social contacto)
        {
            throw new NotImplementedException();
        }

        public string Delete(Social contacto)
        {
            throw new NotImplementedException();
        }

        public bool exists(Social contacto)
        {
            throw new NotImplementedException();
        }

        public List<Social> GetAll()
        {
            if (contactoSocial.Count == 0) { return null; }

            return contactoSocial;
        }

        public List<Social> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Social GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public string Update(Social contacto)
        {
            throw new NotImplementedException();
        }
    }
}
