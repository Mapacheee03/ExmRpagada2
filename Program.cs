using System.Collections.Generic;
using ExmR2;

namespace Recuperacion_4_FAOG
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ListaLogica lista = new ListaLogica();
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Ordenar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion: ");
                string opciones = Console.ReadLine();

                if (int.TryParse(opciones, out opcion))
                {
                    
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingresa un Nombre:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el Precio:");
                            int precio;
                            if (int.TryParse(Console.ReadLine(), out precio))
                            {
                                Producto producto = new Producto
                                {
                                    Nombre = nombre,
                                    Precio = precio
                                };
                                lista.Insertar(producto);
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un precio válido.");
                            }
                            break;
                        case 2:
                            lista.MostrarElementos();
                            break;

                        case 3:
                            lista.OrdenarPorPrecio();
                            Console.WriteLine("Lista ordenada por precio:");
                            lista.MostrarElementos();
                            break;

                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
                            break;
                    }
                }
               else
                {
                    Console.WriteLine("Ingrese un número válido.");
                }
            } 
        }

       

    }
}
