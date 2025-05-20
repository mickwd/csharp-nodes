using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeEnlazadas
{
    internal class Nodo
    {
        public string Dato { get; set; } // Se establece la priopiedad 'dato' como <string>
        public Nodo Siguiente { get; set; } // Se hace 'recursivo' la clase.

        public Nodo(string _dato) // Se crea la funcion Nodo para poder crear nodos mas tarde.
        { 
            Dato = _dato;
            Siguiente = null; // null
        }
    }
}
