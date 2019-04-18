using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura de la piramide: ");
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
                    for (int i = 1; i <= (altura * 2); i = i + 2)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
