using System;
using ExmR2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmR2
{
    internal class Nodo
    {

        private Producto _producto;
        private Nodo _Siguiente;



        public Nodo(Producto producto)
        {
            _producto = producto;
            _Siguiente = null;
        }
        public Nodo(Producto producto, Nodo siguiente)
        {
            _producto = producto;
            _Siguiente = siguiente;
        }
        public Nodo LSiguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
        public Producto LProducto
        {
            get { return _producto; }
            set { _producto = value; }
        }


    }
}
