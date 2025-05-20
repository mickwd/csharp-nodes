using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeEnlazadas
{
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string _dato) 
        { 
            Dato = _dato;
            Siguiente = null;
        }
    }
}
