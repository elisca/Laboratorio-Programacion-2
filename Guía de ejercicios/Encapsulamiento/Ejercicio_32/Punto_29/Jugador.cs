using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_29
{
    class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        int totalGoles;

        public int Dni
        {
            get 
            {
                return this.dni; 
            }
            set 
            {
                this.dni = value; 
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre; 
            }
            set 
            {
                this.nombre = value; 
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

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        
        public string MostrarDatos()
        {
            StringBuilder datosJugador = new StringBuilder();

            datosJugador.AppendLine("DNI: " + this.dni);
            datosJugador.AppendLine("Nombre: " + this.nombre);
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
            return (j1.dni == j2.dni);
        }
    }
}
