using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta >=0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
        
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool returnAux = false;
            dibujo = "";
            int resto = this.GetTinta() - (short)gasto;
            if (resto > 0)
            {
                this.SetTinta((short)resto);
                returnAux = true;

                for(int i = 1; i <= gasto; i++)
                {
                    dibujo += '*';  
                }
            }

            return returnAux;
        }
    }
}
