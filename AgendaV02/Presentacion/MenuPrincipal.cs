using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        int op;
        ContactoFamiliarGUI contactosf = new ContactoFamiliarGUI();
        public void MostrarAgenda(int l , int t)
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l + 20, t + 1);Console.WriteLine(":             AGENDAS               :");
                Console.SetCursorPosition(l + 20, t + 2);Console.WriteLine(" ...................................");
                Console.SetCursorPosition(l + 20, t + 3); Console.WriteLine(":    1.Agregar                     :");
                Console.SetCursorPosition(l + 20, t + 4); Console.WriteLine(":    2.Consultar                   :");
                Console.SetCursorPosition(l + 20, t + 5); Console.WriteLine(":    3.Salir                       :");
                Console.SetCursorPosition(l + 20, t + 6); Console.WriteLine(" ...................................");
                Console.SetCursorPosition(l + 20, t + 8);  op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        CrearContactos(15, 5);
                        break;
                    case 2:
                        MostrarAgenda(15, 5);
                        break;
                    case 3:

                        break;
                }

            } while (l < t);
        }
        public void CrearContactos(int l, int t)
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(l + 20, t + 1); Console.WriteLine("·····································");
                Console.SetCursorPosition(l + 20, t + 2); Console.WriteLine(":             CONTACTOS              :");
                Console.SetCursorPosition(l + 20, t + 3); Console.WriteLine("·····································");
                Console.SetCursorPosition(l + 20, t + 4); Console.WriteLine(":     1. Contactos familiar          :");
                Console.SetCursorPosition(l + 20, t + 6); Console.WriteLine(":     2. Contacto Empresarial        :");
                Console.SetCursorPosition(l + 20, t + 8); Console.WriteLine(":     3. Salir                       :");
                Console.SetCursorPosition(l + 20, t + 9); Console.WriteLine("·····································");
                Console.SetCursorPosition(l + 20, t + 16); Console.WriteLine(" digite opcion por favor ...");
                Console.SetCursorPosition(l + 48, t + 18);int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        contactosf.CapturarDatos();
                        break;

                    case 2:

                        break;
                    case 3:
                        break;


                }


            } while (op != 3);
        }
        public void MostrarContactos(int l, int t)
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(l + 20, t + 1); Console.WriteLine("·····································");
                Console.SetCursorPosition(l + 20, t + 2); Console.WriteLine(":             CONTACTOS              :");
                Console.SetCursorPosition(l + 20, t + 3); Console.WriteLine("·····································");
                Console.SetCursorPosition(l + 20, t + 4); Console.WriteLine(":     1. Contactos familiar          :");
                Console.SetCursorPosition(l + 20, t + 6); Console.WriteLine(":     2. Contacto Empresarial        :");
                Console.SetCursorPosition(l + 20, t + 8); Console.WriteLine(":     3. Salir                       :");
                Console.SetCursorPosition(l + 20, t + 9); Console.WriteLine("·····································");
                Console.SetCursorPosition(l + 20, t + 16); Console.WriteLine(" digite opcion por favor ...");
                Console.SetCursorPosition(l + 48, t + 18); int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        contactosf.Consultar();
                        break;

                    case 2:

                        break;

                    case 3:
                        break;


                }


            } while (op != 3);
        }
    }
}
