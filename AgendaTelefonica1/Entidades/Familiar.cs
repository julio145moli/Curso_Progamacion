using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Persona
    {
        public Familiar()
        {
        }

        public Familiar(int id, string nombre, string apellido, string telefono, DateTime fechaNacimiento) : base(id, nombre, apellido, telefono)
        {
            FechaNacimiento= fechaNacimiento;
        }


        public DateTime FechaNacimiento { get; set; }
        public int Edad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
        public override string ToString()
        {
            return  $"{id};{Nombre};{Apellido};{Telefono};{FechaNacimiento.ToShortDateString()}";
        }

        //public  string Linea()
        //{
        //    return $"{id};{Nombre};{Apellido};{Telefono};{FechaNacimiento.ToShortDateString()}";
        //}
        //public override string ToString()
        //{

        //    return $"{id};{Nombre};{Telefono};{FechaNacimiento.ToShortDateString()}";
        //}
    }


    
}
