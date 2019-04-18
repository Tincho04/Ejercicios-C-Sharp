using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;

        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Asignar() {
            string valorAux;
            int valor1, valor2;
            Console.WriteLine("Ingrese el eje X");
            valorAux = Console.ReadLine();
            int.TryParse(valorAux, out valor1);
            Console.WriteLine("Ingrese el eje Y");
            valorAux = Console.ReadLine();
            int.TryParse(valorAux, out valor2);
            this.x = valor1;
            this.y = valor2;         
        }
    }
}
