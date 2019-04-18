using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaNacimiento, mesNacimiento, anioNacimiento;
            int diaActual, mesActual, anioActual;
            int diasVividos, mesesVividos, aniosVividos;
            int valiDia, valiMes, valiAnio;
            int diasBisiesto;
            int flag = 1;
            string diaStr, mesStr, anioStr;
            DateTime fechaActual = DateTime.Now;

            anioActual = fechaActual.Year;
            mesActual = fechaActual.Month;
            diaActual = fechaActual.Day;

            Console.WriteLine("Fecha de nacimiento");
            Console.Write("Ingrese dia: ");
            diaStr = Console.ReadLine();
            Console.Write("Ingrese mes: ");
            mesStr = Console.ReadLine();
            Console.Write("Ingrese anio: ");
            anioStr = Console.ReadLine();
            int.TryParse(diaStr, out valiDia);
            int.TryParse(mesStr, out valiMes);
            int.TryParse(anioStr, out valiAnio);
            if (valiMes <= 0 || valiMes >= 13)
            {
                flag = 0;
                Console.WriteLine("Mes no valido");
            }
            else if ((valiAnio % 4 == 0 && valiMes == 2) && (valiDia <= 0 || valiDia > 29))
            {
                flag = 0;
                Console.WriteLine("Dia no valido");
            }
            else if ((valiAnio % 4 != 0 && valiMes == 2) && (valiDia <= 0 || valiDia > 28))
            {
                flag = 0;
                Console.WriteLine("Dia no valido");
            }
            else if ((valiMes == 4 || valiMes == 6 || valiMes == 9 || valiMes == 11) && (valiDia <= 0 || valiDia > 30))
            {
                flag = 0;
                Console.WriteLine("Dia no valido");
            }
            else if ((valiMes == 1 || valiMes == 3 || valiMes == 5 || valiMes == 7 || valiMes == 8 || valiMes == 10 || valiMes == 12) && (valiDia <= 0 || valiDia > 31))
            {
                flag = 0;
                Console.WriteLine("Dia no valido");
            }

            if (flag == 1)
            {
                Console.WriteLine(fechaActual);
                Console.WriteLine("Fecha de Nacimiento: {0}/{1}/{2}", diaStr, mesStr, anioStr);

                if ((int.TryParse(diaStr, out diaNacimiento)) && (int.TryParse(mesStr, out mesNacimiento)) && (int.TryParse(anioStr, out anioNacimiento)))
                {
                    aniosVividos = anioActual - anioNacimiento;
                    diasBisiesto = (aniosVividos / 4);
                    mesesVividos = mesActual - mesNacimiento;

                    diasVividos = (aniosVividos * 365) + ((mesesVividos * 30) - diaNacimiento) + diasBisiesto + diaActual;

                    Console.WriteLine("Dias vividos a la fecha actual: {0}", diasVividos);
                }
            }
            Console.ReadKey();
        }
    }
}
