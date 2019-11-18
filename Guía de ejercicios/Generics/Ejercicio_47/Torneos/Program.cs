using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ejercicio_47;

namespace Torneos
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Argentina");

            EquipoBasquet[] equiposBasquet = new EquipoBasquet[3];
            EquipoFutbol[] equiposFutbol = new EquipoFutbol[3];

            equiposBasquet[0] = new EquipoBasquet("Equipo Basquet 1", DateTime.Parse("01/01/2019"));
            equiposBasquet[1] = new EquipoBasquet("Equipo Basquet 2", DateTime.Parse("02/01/2019"));
            equiposBasquet[2] = new EquipoBasquet("Equipo Basquet 3", DateTime.Parse("03/01/2019"));

            equiposFutbol[0] = new EquipoFutbol("Equipo Futbol 1", DateTime.Parse("15/01/2019"));
            equiposFutbol[1] = new EquipoFutbol("Equipo Futbol 2", DateTime.Parse("16/01/2019"));
            equiposFutbol[2] = new EquipoFutbol("Equipo Futbol 3", DateTime.Parse("17/01/2019"));

            foreach (EquipoBasquet auxEquipoBasquet in equiposBasquet)
            {
                if (torneoBasquet + auxEquipoBasquet)
                {
                    Console.WriteLine("Se agrega exitosamente al equipo de Basquet al torneo de ese tipo.");
                }
                else
                {
                    Console.WriteLine("No se logra agregar al equipo de Basquet al torneo de ese tipo.");
                }
            }

            foreach (EquipoFutbol auxEquipoFutbol in equiposFutbol)
            {
                if (torneoFutbol + auxEquipoFutbol)
                {
                    Console.WriteLine("Se agrega exitosamente al equipo de futbolistas al torneo de ese tipo.");
                }
                else
                {
                    Console.WriteLine("No se logra agregar al equipo de futbolistas al torneo de ese tipo.");
                }
            }

            Console.WriteLine(torneoBasquet.Mostrar());

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(torneoBasquet.JugarPartido);
                Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}
