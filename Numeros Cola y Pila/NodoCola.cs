using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Cola_y_Pila
{
    internal class NodoCola
    {
        public int Dato { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
