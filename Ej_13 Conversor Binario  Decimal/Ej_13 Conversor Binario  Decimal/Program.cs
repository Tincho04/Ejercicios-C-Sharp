using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor Binario-Decimal";

            string numeroDecimalStr, numeroBinarioStr, opcionStr;
            double numeroDecimal;
            char opcion;

            Console.Write("Elija que tipo de conversión quiere realizar: \n");
            Console.Write("D - Decimal a Binario \n");
            Console.Write("B - Binario a Decimal \n");
            opcionStr = Console.ReadLine();
            opcion = char.Parse(opcionStr);

            if (opcion == 'D' || opcion == 'd')
            {
                Console.Clear();
                Console.Write("Ingrese su numero decimal: ");
                numeroDecimalStr = Console.ReadLine();

                if (double.TryParse(numeroDecimalStr, out numeroDecimal))
                {
                    numeroBinarioStr = Conversor.DecimalBinario(numeroDecimal);
                    Console.WriteLine("{0} (Decimal) = {1} (Binario)", numeroDecimal, numeroBinarioStr);
                }

            }

            else if (opcion == 'B' || opcion == 'b')
            {
                Console.Clear();
                Console.Write("Ingrese su numero binario: ");
                numeroBinarioStr = Console.ReadLine();

                numeroDecimal = Conversor.BinarioDecimal(numeroBinarioStr);
                Console.WriteLine("{0} (Binario) = {1} (Decimal)", numeroBinarioStr, numeroDecimal);
            }
            else
            {
                Console.Write("Opción no válida");
            }
            Console.ReadKey();
        }
    }

    class Conversor
    {
        public static string DecimalBinario(double numeroDecimal)
        {
            string numeroBinario = "";
            long cociente = (long)numeroDecimal;
            long resto = (long)numeroDecimal;

            while (cociente >= 1)
            {
                resto = cociente % 2;
                cociente = cociente / 2;

                if (resto != 0)
                {
                    numeroBinario = "1" + numeroBinario;
                }
                else
                {
                    numeroBinario = "0" + numeroBinario;
                }
            }

            return numeroBinario;
        }

        public static double BinarioDecimal(string numeroBinario)
        {
            double numeroDecimal = 0;
            int potencia = 1;

            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    numeroDecimal += potencia;
                }
                potencia *= 2;
            }
            return numeroDecimal;
        }
    }
}