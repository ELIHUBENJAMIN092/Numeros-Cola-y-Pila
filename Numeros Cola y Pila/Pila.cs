using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Cola_y_Pila
{
    internal class Pila
    {
        private NodoPila cima;

        public Pila()
        {
            cima = null;
        }

        public void Apilar(int dato)
        {
            NodoPila nuevoNodo = new NodoPila(dato);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
        }

        public int Desapilar()
        {
            if (cima == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            int dato = cima.Dato;
            cima = cima.Siguiente;
            return dato;
        }

        public bool EstaVacia()
        {
            return cima == null;
        }
    }
}
