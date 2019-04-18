using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura del arbol: ");
            int altura;
            if (int.TryParse(Console.ReadLine(), out altura))
            {
                if (altura < 0)
                {
                    Console.Write("No se ha ingresado un valor valido");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();

                    int altoDuplicado = (altura * 2);
                    string aux;

                    for (int i = 1; i <= altoDuplicado; i = i + 2)
                    {
                        aux = "";
                        for (int j = 1; j <= i; j++)
                        {
                            aux += "*";
                        }
                        Console.Write(Centrado(aux, altoDuplicado));
                        Console.WriteLine();

                    }
                }
            }

            Console.ReadKey();
        }

        static string Centrado(string s, int longitud)
        {
            if (s.Length >= longitud)
            {
                return s;
            }
            int firstpad = (s.Length + longitud) / 2;
            return s.PadLeft(firstpad).PadRight(longitud);
        }
    }
}
