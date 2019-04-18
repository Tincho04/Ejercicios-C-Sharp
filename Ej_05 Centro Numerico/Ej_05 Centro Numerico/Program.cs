using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroStr;
            int numero, i, flag = 0;
            int acum = 0, suma = 0, aux = 0;

            Console.Write("Ingrese un tope de rango de busqueda: ");
            numeroStr = Console.ReadLine();

            if (int.TryParse(numeroStr, out numero))
            {
                for (i = 2; i < numero; i++)
                {
                    acum = acum + (i - 1);
                    suma = i + 1;
                    aux = suma + 1;

                    while (suma <= acum)
                    {
                        suma = suma + aux;

                        if (suma == acum)
                        {
                            flag = 1;
                            Console.WriteLine("{0} es centro numerico grupo 1: {1} grupo 2: {2}", i, acum, suma);
                        }
                        aux++;
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No se han podido encontrar centros numericos en el rango otorgado");
            }
            Console.ReadKey();
        }
    }
}
