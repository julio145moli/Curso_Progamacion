using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ContactoSocialGUI
    {
        ServicioContactoSocial servicioContactoSocial = new ServicioContactoSocial();
        public void CapturarDatos()
        {
            var contacto = new Social();

            Console.Clear();
            Console.WriteLine("Datos de contactos sociales");
            contacto.id = new Random().Next(1, 40);
            Console.WriteLine("Nombre: "); contacto.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: "); contacto.Apellido = Console.ReadLine();
            Console.WriteLine("Telefono: "); contacto.Telefono = Console.ReadLine();
           

            var msg = servicioContactoSocial.Add(contacto);
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        public void Consultar()
        {
            int i = 2;
            Console.Clear();
            Console.SetCursorPosition(35, 5); Console.WriteLine("Listado de contactos familiares");
            Console.SetCursorPosition(30, 8); Console.Write("ID");
            Console.SetCursorPosition(35, 8); Console.Write("NOMBRE");
            Console.SetCursorPosition(50, 8); Console.Write("APELLIDO");
            Console.SetCursorPosition(60, 8); Console.Write("TELEFONO");
            Console.SetCursorPosition(73, 8); Console.Write("FECHA");
            foreach (var item in servicioContactoSocial.GetAll())
            {
                Console.SetCursorPosition(30, 8 + i); Console.Write(item.id);
                Console.SetCursorPosition(35, 8 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(40, 8 + i); Console.Write(item.Apellido);
                Console.SetCursorPosition(50, 8 + i); Console.Write(item.Telefono);
                i++;
            }
            Console.ReadKey();
        }
    }
}

