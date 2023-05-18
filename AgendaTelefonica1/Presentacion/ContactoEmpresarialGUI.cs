using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ContactoEmpresarialGUI
    {
        ServicioContactoEmpresarial servicioContactoEmpresarial = new ServicioContactoEmpresarial();
        public void CapturarDatos()
        {
            var contacto = new Empresarial();

            Console.Clear();
            Console.WriteLine("Datos de contactos empresarial");
            contacto.id = new Random().Next(1, 40);
            Console.WriteLine("Nombre: "); contacto.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: "); contacto.Apellido = Console.ReadLine();
            Console.WriteLine("Telefono: "); contacto.Telefono = Console.ReadLine();
            Console.WriteLine("Empresa: "); contacto.NombreEmpresa = Console.ReadLine();
            Console.WriteLine("Sector: "); contacto.Sector = Console.ReadLine();
            Console.WriteLine("Correo Empresa: "); contacto.CorreoEmpresa = Console.ReadLine();

            var msg = servicioContactoEmpresarial.Add(contacto);
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        public void Consultar()
        {
            int i = 2;
            Console.Clear();
            Console.SetCursorPosition(35, 5); Console.WriteLine("Listado de contactos empresariales");
            Console.SetCursorPosition(30, 8); Console.Write("ID");
            Console.SetCursorPosition(35, 8); Console.Write("NOMBRE");
            Console.SetCursorPosition(50, 8); Console.Write("APELLIDO");
            Console.SetCursorPosition(60, 8); Console.Write("TELEFONO");
            Console.SetCursorPosition(73, 8); Console.Write("EMPRESA");
            Console.SetCursorPosition(82, 8); Console.Write("SECTOR");
            Console.SetCursorPosition(93, 8); Console.Write("CORREO");

            foreach (var item in servicioContactoEmpresarial.GetAll())
            {
                Console.SetCursorPosition(30, 8 + i); Console.Write(item.id);
                Console.SetCursorPosition(35, 8 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(40, 8 + i); Console.Write(item.Apellido);
                Console.SetCursorPosition(50, 8 + i); Console.Write(item.Telefono);
                Console.SetCursorPosition(60, 8 + i); Console.Write(item.NombreEmpresa);
                Console.SetCursorPosition(70, 8 + i); Console.Write(item.Sector);
                Console.SetCursorPosition(80, 8 + i); Console.Write(item.CorreoEmpresa);

                i++;
            }
            Console.ReadKey();
        }
    }
}
