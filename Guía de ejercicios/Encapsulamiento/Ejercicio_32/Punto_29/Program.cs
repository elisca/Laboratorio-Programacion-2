using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo bocaJuniors = new Equipo(3, "Boca Juniors");
            Equipo velezSarsfield = new Equipo(2, "Velez Sarsfield");

            Jugador jugador00 = new Jugador(0, "A Jugador", 10, 10);
            Jugador jugador01 = new Jugador(1, "B Jugador", 20, 10);
            Jugador jugador02 = new Jugador(2, "C Jugador", 30, 10);
            Jugador jugador03 = new Jugador(3, "D Jugador", 40, 10);
            Jugador jugador04 = new Jugador(4, "E Jugador", 50, 10);
            Jugador jugador05 = new Jugador(5, "F Jugador", 60, 10);

            List<Jugador> listaJugadores = new List<Jugador>();

            Console.WriteLine("Agregar jugadores a Boca Juniors:");
            listaJugadores.Add(jugador00);
            listaJugadores.Add(jugador00);
            listaJugadores.Add(jugador01);
            listaJugadores.Add(jugador02);
            listaJugadores.Add(jugador03);
            listaJugadores.Add(jugador04);
            listaJugadores.Add(jugador05);

            for (int i = 0; i < listaJugadores.Count; i++)
            {
                if (bocaJuniors + listaJugadores[i])
                {
                    Console.WriteLine("Se agregó jugador.");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar al jugador.");
                }
            }

            Console.WriteLine("\nAgregar jugadores a Velez Sarsfield:");
            for (int i = 0; i < listaJugadores.Count; i++)
            {
                if (velezSarsfield + listaJugadores[i])
                {
                    Console.WriteLine("Se agregó jugador.");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar al jugador.");
                }
            }

            Console.WriteLine("\nMostrar datos de un jugador:");
            Console.WriteLine("{0}", jugador00.MostrarDatos());

            Console.ReadKey();
        }
    }
}
