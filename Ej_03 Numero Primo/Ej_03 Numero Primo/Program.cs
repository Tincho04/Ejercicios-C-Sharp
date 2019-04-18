using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i;
            string aux;
            Console.WriteLine("Ingrese el numero \n");
            aux = Console.ReadLine();
            int.TryParse(aux, out numero);
            for (i = 2; i <= numero; i++)
            {
                if (i != 2 && i != 3)
                {
                    if ((i % 2 != 0) && (i % 3 != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}