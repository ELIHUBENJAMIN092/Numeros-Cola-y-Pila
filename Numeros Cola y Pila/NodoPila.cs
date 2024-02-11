using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Cola_y_Pila
{
    internal class NodoPila
    {
        public int Dato { get; set; }
        public NodoPila Siguiente { get; set; }

        public NodoPila(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
