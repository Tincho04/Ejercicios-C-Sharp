using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio, anioFin, anioAnalizar, flag = 0;
            string anioInicioStr, anioFinalStr;

            Console.Write("Ingrese anio de inicio: ");
            anioInicioStr = Console.ReadLine();
            Console.Write("Ingrese anio final: ");
            anioFinalStr = Console.ReadLine();

            if ((int.TryParse(anioInicioStr, out anioInicio)) && (int.TryParse(anioFinalStr, out anioFin)))
            {
                for (anioAnalizar = anioInicio; anioAnalizar <= anioFin; anioAnalizar++)
                {
                    if (anioAnalizar % 100 == 0 && anioAnalizar % 400 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (anioAnalizar % 4 == 0)
                        {
                            flag = 1;
                            Console.WriteLine("El anio {0} es bisiesto.", anioAnalizar);
                        }
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No se han hallado anios bisiestos en el rango otorgado");
            }
            Console.ReadKey();
        }
    }
}
