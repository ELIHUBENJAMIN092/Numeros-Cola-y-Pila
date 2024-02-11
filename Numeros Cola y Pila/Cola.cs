using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Cola_y_Pila
{
    internal class Cola
    {
        private NodoCola frente;
        private NodoCola final;

        public Cola()
        {
            frente = final = null;
        }

        public void Encolar(int dato)
        {
            NodoCola nuevoNodo = new NodoCola(dato);

            if (final == null)
            {
                frente = final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }

        public int Desencolar()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            int dato = frente.Dato;
            frente = frente.Siguiente;

            if (frente == null)
            {
                final = null;
            }

            return dato;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }
    }
}
