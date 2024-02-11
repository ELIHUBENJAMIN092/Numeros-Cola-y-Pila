using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Cola_y_Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cola
            Cola colaNumeros = new Cola();

            // Ingresar números a la cola
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            colaNumeros.Encolar(numero1);

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            colaNumeros.Encolar(numero2);

            Console.Write("Ingrese el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());
            colaNumeros.Encolar(numero3);

            // Crear una pila y apilar los números de la cola
            Pila pilaNumeros = new Pila();
            while (!colaNumeros.EstaVacia())
            {
                int numero = colaNumeros.Desencolar();
                pilaNumeros.Apilar(numero);
            }

            // Imprimir los números apilados
            {
                Console.WriteLine("\n *************************************** \n Estos son los numeros ingresados a la cola y desapilados \n ***************************************\n ");
                Console.ReadLine();
            }

            Console.WriteLine("Números apilados:");
            while (!pilaNumeros.EstaVacia())
            {
                int numero = pilaNumeros.Desapilar();
                Console.WriteLine(numero);
                Console.ReadLine();

            }
            {
                Console.WriteLine("********** Fin **********");
                Console.ReadLine();
            }
        }
    }
}