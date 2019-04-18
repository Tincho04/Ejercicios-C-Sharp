using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAux;
            int num, i;
            float promedio;
            int max = 0;
            int min = 0;
            int total = 0;
            bool returnTryParse;

            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write("Ingrese el valor numero {0}: ", i);
                    numAux = Console.ReadLine();
                    returnTryParse = int.TryParse(numAux, out num);

                } while (!Validacion.Validar(num, -100, 100) || !int.TryParse(numAux, out num));

                if (int.TryParse(numAux, out num))
                {
                    if (i == 0)
                    {
                        max = num;
                        min = num;
                        promedio = num;
                    }
                    else
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                        if (num < min)
                        {
                            min = num;
                        }
                    }

                    total = total + num;
                }
            }

            promedio = total / 10;

            Console.Clear();
            Console.WriteLine("Numero maximo: {0}", max);
            Console.WriteLine("Numero minimo: {0}", min);
            Console.WriteLine("Promedio: {0:#,###.00}", promedio);
            Console.ReadKey();
        }
    }

    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool returnAux = true;

            if (valor < min || valor > max)
            {
                returnAux = false;
            }
            return returnAux;
        }
    }
}
