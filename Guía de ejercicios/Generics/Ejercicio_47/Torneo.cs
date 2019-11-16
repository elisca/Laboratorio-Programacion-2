using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Torneo<T> where T: Equipo
    {
        List<T> equipos;
        string nombre;
        Random numRandom;

        public Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            return t.equipos.Contains(e);
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            bool equipoAgregado = false;

            if (t != e)
            {
                t.equipos.Add(e);
                equipoAgregado = true;
            }

            return equipoAgregado;
        }

        public string Mostrar()
        {
            StringBuilder datosTorneo = new StringBuilder();

            datosTorneo.AppendLine("Nombre de torneo: " + this.nombre);
            datosTorneo.AppendLine("Lista de equipos participantes:");

            foreach (Equipo auxEquipo in this.equipos)
            {
                datosTorneo.AppendLine("\t" + auxEquipo.Ficha());
            }

            return datosTorneo.ToString();
        }

        string CalcularPartido(T equipo1, T equipo2)
        {
            StringBuilder datosPartido = new StringBuilder();
            int resultado1, resultado2;

            resultado1 = numRandom.Next(0, 4);
            resultado2 = numRandom.Next(0, 4);

            datosPartido.AppendFormat("{0} {1}-{2} {3}", equipo1.Nombre, resultado1, equipo2.Nombre, resultado2);

            return datosPartido.ToString();
        }

        public string JugarPartido
        {
            get 
            {
                int equipo1 = numRandom.Next(0, this.equipos.Count - 1);
                int equipo2 = numRandom.Next(0, this.equipos.Count - 1);
                return this.CalcularPartido(this.equipos[equipo1], this.equipos[equipo2]);
            }
        }
    }
}
