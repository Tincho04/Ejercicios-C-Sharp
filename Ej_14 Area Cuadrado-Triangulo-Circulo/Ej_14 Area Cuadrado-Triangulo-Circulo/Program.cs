using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cálculo de Area";

            double ladoCuadrado, baseTriangulo, alturaTriangulo, radioCirculo;
            string ladoCuadradoStr, baseTrianguloStr, alturaTrianguloStr, radioCirculoStr, opcionStr;
            double areaCuadrado, areaTriangulo, areaCirculo;
            int opcion;

            Console.Write("Seleccione que calculo desea realizar: \n");
            Console.Write("1 - Calcular Area del Cuadrado  \n");
            Console.Write("2 - Calcular Area del Triangulo \n");
            Console.Write("3 - Calcular Area del Circulo   \n");
            opcionStr = Console.ReadLine();

            if (int.TryParse(opcionStr, out opcion))
            {

                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("AREA CUADRADO\n");
                        Console.Write("Ingrese lado del cuadrado: ");
                        ladoCuadradoStr = Console.ReadLine();

                        if (double.TryParse(ladoCuadradoStr, out ladoCuadrado))
                        {
                            areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                            Console.WriteLine("Area del cuadrado: {0}", areaCuadrado);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nAREA TRIANGULO\n");
                        Console.Write("Ingrese base del triangulo: ");
                        baseTrianguloStr = Console.ReadLine();
                        Console.Write("Ingrese altura del triangulo: ");
                        alturaTrianguloStr = Console.ReadLine();

                        if (double.TryParse(baseTrianguloStr, out baseTriangulo) && double.TryParse(alturaTrianguloStr, out alturaTriangulo))
                        {
                            areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                            Console.WriteLine("Area del triangulo: {0}", areaTriangulo);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\nAREA CIRCULO\n");
                        Console.Write("Ingrese el radio circulo: ");
                        radioCirculoStr = Console.ReadLine();

                        if (double.TryParse(radioCirculoStr, out radioCirculo))
                        {
                            areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);
                            Console.WriteLine("Area del circulo: {0}", areaCirculo);
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.Write("Opción no válida");
                        break;
                }
            }
            else
            {
                Console.Write("Opción no válida");
            }

            Console.ReadKey();
        }
    }

    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = Math.Pow(lado, 2);
            return area;
        }

        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double area = (baseTriangulo * altura) / 2;
            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area = Math.Pow(radio, 2) * Math.PI;
            return area;
        }
    }
}