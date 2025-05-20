using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasSimplementeEnlazadas
{
    internal class Lista
    {
        public Nodo Centinela; // Cargo el primer nodo (vacio) para poder trabajar sobre el.
        public Lista()
        {                       // Establezco que el Centinela es null cuando arranca el programa
            Centinela = null;   // (por que no hay nada con lo que arranque).
        }

        // PASO 1: COMO CARGAR UNA LISTA Y MOSTRARLA.
        public void CargarListaR(Nodo actual, List<string> result) // Funcion recursiva para cargar datos a la lista.
        {
            if (actual != null)                         // Si 'actual' (Centinela) es distinto a null (Si existe algun Nodo creado).
            {
                result.Add(actual.Dato);                // Se agrega el dato del centinela a la lista.
                CargarListaR(actual.Siguiente, result); // Se vuelve a llamar con el nodo siguiente (Centinela.Siguiente).
            }
        }
        public List<string> MostrarLista() // Procedimiento para mostrar la lista completa.
        {
            List<string> result = new List<string>(); // Se crea una lista 'simbolica' (de tipo <string>) para poder operar libremente [posteriormente se copia y pega en la lista real (ListBox1)]
            CargarListaR(Centinela, result);          // Se llama a la funcion recursiva para cargar datos.
            return result;                            // Devuelve la lista 'simbolica' ya cargada a quien la solicite.
        }

        // PASO 2: COMO AGREGAR NODOS.
        public void AgregarAlInicio(string _dato)
        {
            Nodo X = new Nodo(_dato); // Creo un nuevo dato y le asigno el valor del input1 (Se crea facilmente gracias a la funcion que se hizo en Nodo.cs)
            X.Siguiente = Centinela;  // Establezco que X.Siguiente va a tener las mismas propiedades que Centinela (Por que se agrego al principio).
            Centinela = X;            // El nodo X pasa a ser el nuevo Centinela.
        }
        public void AgregarAlFinal(string _dato)
        {
            Nodo X = new Nodo(_dato);   // Creo el nodo con el dato a agregar.

            if (Centinela == null)      // Si Centinela no existe (Si no hay nada en la lista):
            {
                Centinela = X;          // Centinela pasa a ser X.
            }
            else                        // Si existe algun dato en la lista (y por ende el Centinela tambien):
            {
                AgregarFinalR(Centinela, X); // Se llama a la funcion recursiva para buscar el final y posteriormente
            }                               // agregar el nodo X.
        }
        private void AgregarFinalR(Nodo Actual, Nodo X)
        {
            if (Actual.Siguiente == null) // Si Actual.Siguiente == null llegamos al final, por que no hay nada
            {                             // despues del Actual (Nodo que estamos analizando para ver si es el ultimo).
                Actual.Siguiente = X;
            }                             // Establecemos que el .Siguiente del ultimo nodo pasa a ser el nodo nuevo.
            else
            {
                AgregarFinalR(Actual.Siguiente, X); // Si no es el ultimo nodo, se vuelve a llamar a la funcion con
            }                                      // el .Siguiente del nodo que analizamos anteriormente.
        }

        // PASO 3: COMO ELIMINAR NODOS.
        public void EliminarAlInicio()
        {
            if (Centinela != null)                  // Si el centinela existe:
            {                           
                Centinela = Centinela.Siguiente;    // El centinela pasa a ser su siguiente (Se elimina automaticamente).
            }
        }
        public void EliminarAlFinal()
        {
            if (Centinela != null)      // Si el centinela existe:
            {
                EliminarFinalR(Centinela, Centinela.Siguiente); // Se llama a la funcion para poder buscar el final (y posteriormente eliminarlo).
            }
        }
        private void EliminarFinalR(Nodo Actual, Nodo Siguiente)
        {
            if (Siguiente.Siguiente == null)    // Si el .Siguiente del Siguiente (Actual.Siguiente.Siguiente)
            {                                   // es null. Se elimina el Actual.Siguiente
                Actual.Siguiente = null;
            }
            else
            {
                EliminarFinalR(Siguiente, Siguiente.Siguiente);  // Si no es null se buscan los siguientes nodos.
            }
        }

        // PASO 4: ELIMINAR EN POSICION N:
        public void EliminarPosN(int y)
        {
            if (y == 0) // Si es 0 la misma posicion marcada se elimina directamente.
            {
                Centinela = Centinela.Siguiente;
            }
            else
            {
                EliminarPosN_R(null, Centinela, y, 0); // Si no es 0, se llama a la funcion recursiva:
            }
        }
        private void EliminarPosN_R(Nodo Aux, Nodo Actual, int y, int x)
        {
            if (y == x) // Si y (pos marcada) es igual a x (cantidad de nodos recorridos), se elimina la posicion.
            {
                Aux.Siguiente = Actual.Siguiente; // NOTA: Esto no funcionaria con 0, por eso se descarta en el if anterior.
            }                                     // Se establece que el Aux.Siguiente pasa a ser Actual.Siguiente, 'Actual' se perderia.
            else
            {
                EliminarPosN_R(Actual, Actual.Siguiente, y, x+1); // Si 'Y != X', se busca con el siguiente nodo, sumando el numero.
            }
        }

        // PASO 5: AGREGAR EN POSICION N:
        public void AgregarPosN(string _dato, int y)
        {
            Nodo nuevo = new Nodo(_dato); // Se crea un nodo con el dato adjunto.

            if (y == 0)     // Si el index es 0, es lo mismo que agregar al principio.
            {
                AgregarAlInicio(_dato); // Se agrega al principio por que el index == 0;
            }
            else
            {
                AgregarPosN_R(Centinela, nuevo, y, 0); // Si no es 0 se llama a la funcion recursiva:
            }
        }
        private void AgregarPosN_R(Nodo Centinela, Nodo nuevo, int pos, int posv)
        {
            if (pos == posv) // Si la pos == posv (pos recorrida): 
            {
                Nodo aux = Centinela.Siguiente;     // Creo un nodo 'aux' para guardar temporalmente el Centinela.Siguiente
                Centinela.Siguiente = nuevo;        // Centinela.Siguiente pasa a ser 'nuevo' (nodo creado anteriormente con _dato)
                nuevo.Siguiente = aux;              // El .Siguiente del nuevo pasa a ser 'aux' (anteriormente Centinela.Siguiente)
            }
            else
            {
                AgregarPosN_R(Centinela.Siguiente, nuevo, pos, posv + 1);   // Si no se cumple se suma 'posv' y se
            }                                                   // pasa al siguiente nodo (Centinela.Siguiente).

        }

        // PASO 6: INTERCAMBIAR POSICIONES:
        public void IntercambiarPosiciones(int x, int y)
        {
            string xa = IntXRecursivo(0, x, Centinela); // Busco el valor en la posicion X (pos1) y lo guardo como 'xa'.
            string ya = IntYRecursivo(0, y, Centinela); // Busco el valor en la posicion Y (pos2) y lo guardo como 'ya'.

            string aux = xa;    // Creo una string 'aux' para guardar temporalmente 'xa' (por que posteriormente se cambia)
            xa = ya;            // Cambio 'xa' y pasa a ser 'ya'
            ya = aux;           // Cambio 'ya' por 'aux' (anteriormente 'xa').

            aIntXRecursivo(0, x, Centinela, xa); // Creo otras 2 funciones recursivas para sobreescribir estos datos.
            aIntYRecursivo(0, y, Centinela, ya);
        }

        // FUNCIONES RECURSIVAS PARA OBTENER EL VALOR DE LA STRING EN LA POSICION X & Y.
        private string IntXRecursivo(int x, int y, Nodo Centinela) 
        {
            if (x == y)     // Si X == Y (pos recorrida al mismo tiempo que con los nodos)
            {
                return Centinela.Dato; // Devuelve el valor (en 'string') del nodo.
            }
            else
            {
                return IntXRecursivo(x + 1, y, Centinela.Siguiente); // Si no es igual, se pasa al centinela siguiente y se suma al 'x' ('x + 1').
            }
        }
        private string IntYRecursivo(int x, int y, Nodo Centinela)
        {
            if (x == y)     // Si X == Y (pos recorrida al mismo tiempo que con los nodos)
            {
                return Centinela.Dato;  // Devuelve el valor (en 'string') del nodo.
            }
            else
            {
                return IntYRecursivo(x + 1, y, Centinela.Siguiente); // Si no es igual, se pasa al centinela siguiente y se suma al 'x' ('x + 1').
            }
        }

        // FUNCIONES RECURSIVAS PARA SOBREESCRIBIR EL VALOR DE LA STRING EN LA POSICION X & Y.
        private void aIntXRecursivo(int x, int y, Nodo Centinela, string _dato)
        {
            if (x == y) // Si X == Y (pos recorrida al mismo tiempo que con los nodos)
            {
                Centinela.Dato = _dato; // Se sobreescribe el dato de ESE nodo con el '_dato' traido (que guardamos anteriormente).
            }
            else
            {
                aIntXRecursivo(x + 1, y, Centinela.Siguiente, _dato); // Si no es igual, se pasa al centinela siguiente y se suma al 'x' ('x + 1').
            }
        }
        private void aIntYRecursivo(int x, int y, Nodo Centinela, string _dato)
        {
            if (x == y) // Si X == Y (pos recorrida al mismo tiempo que con los nodos)
            {
                Centinela.Dato = _dato; // Se sobreescribe el dato de ESE nodo con el '_dato' traido (que guardamos anteriormente).
            }
            else
            {
                aIntYRecursivo(x + 1, y, Centinela.Siguiente, _dato); // Si no es igual, se pasa al centinela siguiente y se suma al 'x' ('x + 1').
            }
        }

        // PASO 7: BORRAR TODO
        public void BorrarTodo()
        {
            Centinela = null; // Si borras el Centinela (Primer nodo), se borran todos los
        }                     // siguientes (por que se borran 'recursivamente' el .Siguiente.Siguiente.Siguiente y asi...)
    }
}