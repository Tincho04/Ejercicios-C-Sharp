using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado, cubo;
            string aux;
            do
            {
                Console.WriteLine("Ingrese el numero");
                aux = Console.ReadLine();
                int.TryParse(aux, out numero);
                if (numero == 0)
                {
                    Console.WriteLine("Error se ingreso un 0");
                }
            } while (numero == 0);
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado es: " + cuadrado);
            Console.WriteLine("El cubo es: " + cubo);
            Console.ReadKey();
        }
    }
}
