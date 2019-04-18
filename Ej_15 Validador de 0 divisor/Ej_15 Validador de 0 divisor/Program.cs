using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            string operacionStr, opcion;
            char operacion;
            float primerNumero, segundoNumero, resultado;
            bool error, continuar = true;

            do
            {
                Console.WriteLine("Ingrese el primer valor que desea emplear:");
                do
                {
                    if (!float.TryParse(Console.ReadLine(), out primerNumero))
                    {
                        Console.WriteLine("Ingrese un valor valido");
                        error = true;
                    }
                    else
                        error = false;
                } while (error);

                Console.WriteLine("Ingrese la operación a realizar");
                do
                {
                    operacionStr = Console.ReadLine();
                    operacion = char.Parse(operacionStr);
                    if (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
                    {
                        Console.WriteLine("Ingrese una operación valida");
                        error = true;
                    }
                    else
                        error = false;
                } while (error);

                if (operacion == '/')
                {
                    segundoNumero = Validar("Ingrese el segundo valor que desea emplear:", "Ingrese un valor valido");
                }
                else
                {
                    Console.WriteLine("Ingrese el segundo valor que desea emplear:");
                    do
                    {
                        if (!float.TryParse(Console.ReadLine(), out segundoNumero))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                            error = true;
                        }
                        else
                            error = false;
                    } while (error);
                }


                resultado = Calcular(primerNumero, operacion, segundoNumero);
                Console.WriteLine("El resultado de {0} {1} {2} es: {3}", primerNumero, operacion, segundoNumero, resultado);
                Console.ReadKey();
                Console.WriteLine("¿Desea Continuar?");
                opcion = Console.ReadLine();
                if (opcion == "n" || opcion == "N")
                {
                    continuar = false;
                }

            } while (continuar);
        }

        static float Calcular(float valorUno, char operador, float valorDos)
        {
            float total;
            switch (operador)
            {
                case '+':
                    total = valorUno + valorDos;
                    break;

                case '-':
                    total = valorUno - valorDos;
                    break;

                case '*':
                    total = valorUno * valorDos;
                    break;

                case '/':
                    total = valorUno / valorDos;
                    break;
                default:
                    total = 0;
                    break;
            }
            return total;
        }

        static int Validar(String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero == 0)
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
