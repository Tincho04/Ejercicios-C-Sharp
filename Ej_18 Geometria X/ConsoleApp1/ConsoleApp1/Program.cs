using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto primerPunto = new Punto(0,0);
            Punto segundoPunto = new Punto(0, 0);
            Punto tercerPunto = new Punto(0, 0);
            Punto cuartoPunto = new Punto(0, 0);
            Rectangulo rectangulo = new Rectangulo(primerPunto,segundoPunto,tercerPunto,cuartoPunto);
            primerPunto.Asignar();
            segundoPunto.Asignar();
            tercerPunto.Asignar();
            rectangulo.Perimentro();
            rectangulo.Area();
            Console.Write("\nEl perimetro es de: "+ rectangulo.GetPerimetro());
            Console.Write("\nEl area es de: " + rectangulo.GetArea());


            Console.ReadKey();
        }
    }
}
