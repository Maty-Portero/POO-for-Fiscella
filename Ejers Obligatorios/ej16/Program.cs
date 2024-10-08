using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej16
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            AgendaContactos agenda = new AgendaContactos();
            var menus = new Dictionary<string, string[]>
            {
                { " Archivo ", new[] { "Nuevo Contacto", "Modificar Contacto", "Listar Contacto", "Eliminar Contacto", "Salir" } }
            };

            var menuPrincipal = new MenuPrincipal(menus);

            foreach (var subMenu in menus)
            {
                foreach (var opcion in subMenu.Value)
                {
                    if (opcion == "Salir")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa...");
                            Environment.Exit(0);
                        });
                    }
                    else if(opcion == "Nuevo Contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Creando un {opcion}");
                            Console.WriteLine("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Telefono: ");
                            string fono = Console.ReadLine();
                            agenda.aniadirContacto(nombre, fono);

                            Console.WriteLine("Contacto agregado con éxito");
                            Console.WriteLine(" ");

                            Console.WriteLine("Presione cualquier tecla para continuar...");

                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Modificar Contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Buscando un Contacto para modificar");
                            Console.WriteLine("Telefono: ");
                            string fono = Console.ReadLine();
                            Contacto c = agenda.buscaContacto(fono);
                            if (c != null)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Nombre nuevo: ");
                                c.Nombre = Console.ReadLine();
                                Console.WriteLine("Telefono nuevo: ");
                                c.Telefono = Console.ReadLine();
                                
                                Console.WriteLine(" ");
                                Console.WriteLine("Contacto modificado con éxito");
                                Console.WriteLine(" ");

                                Console.WriteLine("Presione cualquier tecla para continuar...");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                            }
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Listar Contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Listado de Contactos");
                            agenda.listarContacto();

                            Console.ReadKey();
                        });
                    }
                    else if(opcion == "Eliminar Contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Buscando un Contacto para eliminar");
                            Console.WriteLine("Telefono: ");
                            string fono = Console.ReadLine();
                            Contacto c = agenda.buscaContacto(fono);
                            if(c != null)
                            {
                                agenda.eliminarContacto(c);

                                Console.WriteLine("Contacto eliminado con éxito");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                            }
                            Console.ReadKey();
                        });
                    }
                }
            }

            var menuNavigator = new MenuNavegacion(menuPrincipal);
            menuNavigator.Iniciar();
        }
    }
}
