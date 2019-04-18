using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto primerPunto, Punto segundoPunto, Punto tercerPunto, Punto cuartoPunto)
        {
            this.vertice1 = primerPunto;
            this.vertice2 = segundoPunto;
            this.vertice3 = tercerPunto;
            this.vertice4 = cuartoPunto;
            this.area = 0;
            this.perimetro = 0;
        }


        private int DistanciaY()
        {
            int puntoA, puntoB, alturaRectangulo;
            puntoA = this.vertice1.GetY();
            puntoB = this.vertice2.GetY();

            if ((puntoA > 0 && puntoB < 0) || (puntoA < 0 && puntoB > 0))
            {
                Math.Abs(puntoA);
                Math.Abs(puntoB);
                alturaRectangulo = puntoA + puntoB;
            }
            else
            {
                Math.Abs(puntoA);
                Math.Abs(puntoB);
                if (puntoA > puntoB)
                {
                    alturaRectangulo = puntoA - puntoB;
                }
                else
                {
                    alturaRectangulo = puntoB - puntoA;
                }
            }
            return alturaRectangulo;
        }


        private int DistanciaX()
        {
            int puntoA,puntoC,baseRectangulo;
            puntoA = this.vertice1.GetX();
            puntoC = this.vertice3.GetX();
            if ((puntoA > 0  && puntoC < 0) || (puntoA < 0 && puntoC > 0))
            {
                Math.Abs(puntoA);
                Math.Abs(puntoC);
                baseRectangulo = puntoA + puntoC;
            }
            else
            {
                Math.Abs(puntoA);
                Math.Abs(puntoC);
                if (puntoA > puntoC)
                {
                    baseRectangulo = puntoA - puntoC;
                }
                else
                {
                    baseRectangulo = puntoC - puntoA; 
                }
            }
            return baseRectangulo;
        }

        public void Perimentro()
        {
            int baseRectangulo, alturaRectangulo;
            baseRectangulo = this.DistanciaX();
            alturaRectangulo = this.DistanciaY();
            baseRectangulo = baseRectangulo * 2;
            alturaRectangulo = alturaRectangulo * 2;
            this.perimetro = baseRectangulo + alturaRectangulo;
        }

        public void Area()
        {
            int baseRectangulo, alturaRectangulo,areaRectangulo;
            baseRectangulo = this.DistanciaX();
            alturaRectangulo = this.DistanciaY();
            areaRectangulo = baseRectangulo * alturaRectangulo;
            this.area = areaRectangulo;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public float GetArea()
        {
            return this.area;
        }
    }
}