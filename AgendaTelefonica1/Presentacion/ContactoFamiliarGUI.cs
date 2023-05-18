using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Presentacion
{
    public class ContactoFamiliarGUI
    {
        ServicioContactoFamiliar ServicioContactoFamiliar = new ServicioContactoFamiliar();
        public void CapturarDatos()
        {
            int d, m, a;
            var contacto = new Familiar();

            Console.Clear();
            Console.WriteLine("Datos de contactos familiares");
            contacto.id = new Random().Next(1, 40);
            Console.WriteLine("Nombre: "); contacto.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: "); contacto.Apellido = Console.ReadLine();
            Console.WriteLine("Telefono: "); contacto.Telefono = Console.ReadLine();
            Console.WriteLine("Fecha");
             
            Console.WriteLine("dia: "); d = int.Parse(Console.ReadLine());
            Console.WriteLine("mes: "); m = int.Parse(Console.ReadLine());
            Console.WriteLine("año: "); a = int.Parse(Console.ReadLine());
            contacto.FechaNacimiento = new DateTime(a, m, d);
            var msg = ServicioContactoFamiliar.Add(contacto);
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        public void Consultar()
        {

            //int i = 2;
            Console.Clear();
            Console.SetCursorPosition(35, 5); Console.WriteLine("Listado de contactos familiares");
            Console.SetCursorPosition(30, 8); Console.Write("ID");
            Console.SetCursorPosition(35, 8); Console.Write("NOMBRE");
            Console.SetCursorPosition(50, 8); Console.Write("APELLIDO");
            Console.SetCursorPosition(60, 8); Console.Write("TELEFONO");
            Console.SetCursorPosition(73, 8); Console.Write("FECHA");
            

            //foreach (var item in ServicioContactoFamiliar.GetAll())
            //{
            //    Console.SetCursorPosition(30, 8 + i); Console.Write(item.id);
            //    Console.SetCursorPosition(35, 8 + i); Console.Write(item.Nombre);
            //    Console.SetCursorPosition(40, 8 + i); Console.Write(item.Apellido);
            //    Console.SetCursorPosition(50, 8 + i); Console.Write(item.Telefono);
            //    Console.SetCursorPosition(63, 8 + i); Console.Write(item.FechaNacimiento.ToShortDateString());
            //    i++; 
            //}
            
            Console.ReadKey();
        }
    }
}