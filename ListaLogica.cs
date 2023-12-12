using ExmR2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExmR2.Producto;

namespace ExmR2
{

    public class ListaLogica
    {
        private Nodo primero;
        private Nodo ultimo;
        Producto producto1 = new Producto();


        public bool Esnulo()
        {
            return primero == null;
        }

        public void Insertar(Producto producto1)
        {
            if (Esnulo())
            {
                primero = ultimo = new Nodo(producto1);
            }
            else
            {
                ultimo.LSiguiente = new Nodo(producto1);
                ultimo = ultimo.LSiguiente;
            }
        }

        public void OrdenarPorPrecio()
        {
            if (Esnulo() || primero.LSiguiente == null)
            {
                Console.WriteLine("La lista está vacía o solo tiene un elemento, no es necesario ordenar.");
                return;
            }

            bool intercambio;
            do
            {
                intercambio = false;
                Nodo actual = primero;
                Nodo anterior = null;

                while (actual.LSiguiente != null)
                {
                    if (actual.LProducto.Precio > actual.LSiguiente.LProducto.Precio)
                    {
                        Nodo temp = actual.LSiguiente;
                        actual.LSiguiente = temp.LSiguiente;
                        temp.LSiguiente = actual;

                        if (anterior != null)
                        {
                            anterior.LSiguiente = temp;
                        }
                        else
                        {
                            primero = temp;
                        }

                        intercambio = true;
                    }

                    anterior = actual;
                    actual = actual.LSiguiente;
                }
            } while (intercambio);
        }

        public void MostrarElementos()
        {
            if (Esnulo())
            {
                Console.WriteLine("La lista está vacía, no hay elementos para mostrar.");
                return;
            }

            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.LProducto.Nombre}, Precio: {actual.LProducto.Precio}");
                actual = actual.LSiguiente;
            }
        }

    }

}
     
    
    
