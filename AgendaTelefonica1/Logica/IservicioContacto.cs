using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Logica
{
    public interface IservicioContacto<T>
    {

        string Add(T contacto);
        string Delete(T contacto);
        List<T> GetAll();
        T GetByPhone(string phone);
        List<T> GetByName(string name);
        string Update(T contacto);
        bool exists(T contacto);
    }
}
