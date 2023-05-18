using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Menu
    {
        public void Principal(int l, int t)
        {
            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 30, +22);


                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Familiar");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. Empresarial");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. Social");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 20, t + 5); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Black;
                        MenuFamiliar(5,5);
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Black;   
                        MenuEmpresarial(5,5);  
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Black;
                        MenuSocial(5, 5);

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("Vuelva pronto");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 6);
      
        
        }


        public void MenuEmpresarial(int l, int t)
        {
            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 30, +22);


                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU EMPRESARIAL");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Agregar contacto");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. Ver lista de contactos");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. Buscar contacto");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. Modificar contacto");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. Eliminar contacto");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. Salir");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("Vuelva pronto");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 6);
        }
        public void MenuFamiliar(int l, int t)
        {
            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 30, +22);


                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU FAMILIAR");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Agregar contacto");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. Ver lista de contactos");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. Buscar contacto");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. Modificar contacto");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. Eliminar contacto");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. Salir");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        new ContactoFamiliarGUI().CapturarDatos();
                        break;
                    case 2:
                        new ContactoFamiliarGUI().Consultar();

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("Vuelva pronto");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 6);
        }
        public void MenuSocial(int l, int t)
        {
            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 30, +22);


                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU SOCIAL");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Agregar contacto");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. Ver lista de contactos");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. Buscar contacto");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. Modificar contacto");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. Eliminar contacto");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. Salir");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("Vuelva pronto");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 6);
        }
    }
}
 
