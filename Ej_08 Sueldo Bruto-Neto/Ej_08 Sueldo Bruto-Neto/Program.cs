using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cantidad;

            cantidad = pedirIntPositivoOCero("Ingrese la cantidad de empleados a registrar", "Error, Ingrese un numero valido");

            string[] nombre = new string[cantidad];
            double[] valorHora = new double[cantidad];
            int[] antiguedad = new int[cantidad];
            int[] horas = new int[cantidad];
            double[] sueldoBruto = new double[cantidad];
            double[] descuentos = new double[cantidad];
            double[] sueldoNeto = new double[cantidad];

            for (i = 0; i < cantidad; i++)
            {
                Console.Clear();
                nombre[i] = pedirString("Ingrese el nombre del empleado: ", "Error.");
                valorHora[i] = pedirDoublePositivo("Ingrese el valor hora del empleado: ", "Error. Reingrese numero mayor a 0");
                antiguedad[i] = pedirIntPositivoOCero("Ingrese la antiguedad del empleado(en anios): ", "Error.");
                horas[i] = pedirIntPositivoOCero("Ingrese las horas trabajadas en el mes: ", "Error.");

                sueldoBruto[i] = (valorHora[i] * horas[i] + antiguedad[i] * 150);
                descuentos[i] = sueldoBruto[i] * 0.13;
                sueldoNeto[i] = sueldoBruto[i] - descuentos[i];

            }

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Empleado:         {0}", nombre[i]);
                Console.WriteLine("Valor de la Hora: {0}", valorHora[i]);
                Console.WriteLine("Antiguedad:       {0}", antiguedad[i]);
                Console.WriteLine("Horas Trabajadas: {0}", horas[i]);
                Console.WriteLine("Sueldo Bruto:     {0}", sueldoBruto[i]);
                Console.WriteLine("Descuentos:       {0}", descuentos[i]);
                Console.WriteLine("Sueldo Neto:      {0} \n", sueldoNeto[i]);
                Console.ReadKey();
            }
        }
        static string pedirString(String mensaje, String mensajeError)
        {
            string input;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                input = Console.ReadLine();
                if (input.Length == 0)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return input;
        }
        static double pedirDoublePositivo(String mensaje, String mensajeError)
        {
            double numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }
        static int pedirIntPositivoOCero(String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }
        static int pedirIntEnIntervalo(int desde, int hasta, String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < desde || numero > hasta)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }

    }
}
