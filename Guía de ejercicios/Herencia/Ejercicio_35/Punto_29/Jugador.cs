using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_29
{
    public class Jugador:Persona
    {
        int partidosJugados;
        int totalGoles;

        public long Dni
        {
            get 
            {
                return base.Dni; 
            }
            set 
            {
                base.Dni = value; 
            }
        }

        public string Nombre
        {
            get
            {
                return base.Nombre; 
            }
            set 
            {
                base.Nombre = value; 
            }
        }

        public int PartidosJugados
        {
            get 
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                float promGoles = this.TotalGoles / this.PartidosJugados;

                return promGoles;
            }
        }

        public int TotalGoles
        {
            get 
            {
                return this.totalGoles; 
            }
        }

        public Jugador(int dni, string nombre):base(dni, nombre)
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        
        public string MostrarDatos()
        {
            StringBuilder datosJugador = new StringBuilder();

            datosJugador.AppendLine("DNI: " + base.Dni);
            datosJugador.AppendLine("Nombre: " + base.Nombre);
            datosJugador.AppendLine("Partidos jugados: " + this.partidosJugados);
            datosJugador.AppendLine("Total goles: " + this.totalGoles);
            datosJugador.AppendLine("Promedio goles: " + this.PromedioGoles);

            return datosJugador.ToString();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Dni == j2.Dni);
        }
    }
}
