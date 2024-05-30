using menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    public class MenuPrincipal
    {
        public List<Menu> menu = new List<Menu>();
        Dictionary<string, Action> acciones = new Dictionary<string, Action>();

        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            int pos = 1;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(pos++, subMenu.Key, subMenu.Value));
                foreach (var opcion in subMenu.Value)
                {
                    if (!acciones.ContainsKey(opcion))
                    {
                        acciones[opcion] = () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Acción por defecto para {opcion}");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        };
                    }
                }
            }
        }

        public void Dibujar(int columna, int fila, int subMenu, int seleccionarItem)
        {
            Console.Clear();

            // Dibuja todos los títulos de los menús
            int columnaInicio = 0;
            foreach (var m in menu)
            {
                Console.SetCursorPosition(columnaInicio, fila);
                Console.BackgroundColor = m.PosMenu == subMenu ? ConsoleColor.DarkGray : ConsoleColor.Black;
                Console.ForegroundColor = m.PosMenu == subMenu ? ConsoleColor.White : ConsoleColor.Gray;
                Console.Write($"{m.NombreMenu}");
                columnaInicio += m.NombreMenu.Length;
            }
            Console.ResetColor();
            Console.WriteLine(); // Salto de línea después de dibujar los títulos

            // Dibuja solo los elementos del menú seleccionado debajo del título correspondiente
            int filaInicio = fila + 1;
            int filaActual = filaInicio;
            foreach (var m in menu)
            {
                if (m.PosMenu == subMenu)
                {
                    foreach (string item in m.Items)
                    {
                        Console.SetCursorPosition(columna, filaActual++);
                        if (m.Items[seleccionarItem] == item)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ResetColor();
                        }
                        Console.WriteLine(item);
                    }
                    break; // Una vez que se dibujan los elementos del menú seleccionado, se sale del bucle
                }
            }
            Console.ResetColor();
        }


        public int ContadorMenu()
        {
            return menu.Count;
        }

        public int ContadorItemMenu(int subMenu)
        {
            return menu[subMenu - 1].Items.Length;
        }

        public string ObtenerNombreMenu(int subMenu)
        {
            return menu[subMenu - 1].NombreMenu;
        }

        public string ObtenerOpcion(int subMenu, int seleccionarItem)
        {
            return menu[subMenu - 1].Items[seleccionarItem];
        }

        public void EjecutarAccion(string opcion)
        {
            if (acciones.ContainsKey(opcion))
            {
                acciones[opcion].Invoke();
            }
        }

        public void AsignarAccion(string opcion, Action accion)
        {
            if (acciones.ContainsKey(opcion))
            {
                acciones[opcion] = accion;
            }
        }
    }
}
