using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];
            int max = 0, min = 0, i, acumulador = 0;
            float promedio;
            int bandera = 0;
            string aux;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                aux = Console.ReadLine();
                int.TryParse(aux, out arreglo[i]);
                if (bandera == 0)
                {
                    max = arreglo[i];
                    min = arreglo[i];
                    bandera = 1;
                }
                Console.WriteLine("numero es " + arreglo[i]);
                if (arreglo[i] > max)
                {
                    max = arreglo[i];
                }
                else if (arreglo[i] < min)
                {
                    min = arreglo[i];
                }
                acumulador = acumulador + arreglo[i];
            }

            promedio = (float)acumulador / 5;
            Console.WriteLine("El numero maximo es: " + max);
            Console.WriteLine("El numero minimo es: " + min);
            Console.WriteLine("El promedio es de: " + promedio);
            Console.ReadKey();
        }
    }
}
