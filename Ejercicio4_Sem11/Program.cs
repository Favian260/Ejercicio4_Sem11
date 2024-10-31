//N00458733

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char omitir;
            string[] nombres = { "jose", "oscar", "carmen", "alexa" };
            string nombre;
            EscribirElementosDelArreglo(nombres);
            Console.Write("Escriba un nombre a buscar: ");
            nombre = Console.ReadLine();
            BuscarElementos(nombres, nombre);
            Console.ReadKey();
        }

        static void EscribirElementosDelArreglo(string[] arreglo)
        {
            Console.WriteLine("Los nombres ingresados son: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }

        static void BuscarElementos(string[] nombre, string nombreABuscar)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombreABuscar == nombre[i])
                {
                    Console.WriteLine($"El nombre buscado {nombreABuscar} es el nombre {i + 1} de la lista.");
                }
            }
        }
    }
}
