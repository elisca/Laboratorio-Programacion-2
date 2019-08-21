using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_17_Boligrafo
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta=0;

        public Boligrafo()
        {
            this.SetTinta(0);
            this.color = ConsoleColor.Black;
        }

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.SetTinta(tinta);
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

        public bool Pintar(int gasto, out string dibujo)
        {
            int nivelTintaNuevo = this.GetTinta() - gasto;
            int porcentajeGasto = 0;

            bool pintarOkey = false;

            this.SetTinta((short)-gasto);
            dibujo = "";
            if (nivelTintaNuevo < 0)
            {
                pintarOkey = false;
                porcentajeGasto = this.GetTinta();
            }
            else
            {
                pintarOkey = true;
                porcentajeGasto = gasto;
            }

            porcentajeGasto /= this.GetTinta();

            for (int i = 1; i <= porcentajeGasto; i++)
            {
                dibujo = string.Concat(dibujo, "*");
            }
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine(dibujo);
            return pintarOkey;
        }

        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            int nuevaTinta = this.GetTinta() + tinta;

            if (nuevaTinta < 0)
            {
                nuevaTinta = 0;
            }
            else if (nuevaTinta > Boligrafo.cantidadTintaMaxima)
            {
                nuevaTinta = Boligrafo.cantidadTintaMaxima;
            }
            //En caso de no ocurrir ninguna de ambas, se mantedrá el valor de nueva tinta asignado al comienzo de esta función.

            this.tinta = (short)nuevaTinta;
        }
    }
}
