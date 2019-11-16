using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47;

namespace Torneos
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>();
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>();
            /*
            EquipoBasquet[] arrayEquiposBasquet = new EquipoBasquet[3];
            EquipoFutbol[] arrayEquiposFutbol = new EquipoFutbol[3];

            arrayEquiposBasquet[0] = new EquipoBasquet("Equipo D", DateTime.Parse("04/11/2019"));
            arrayEquiposBasquet[1] = new EquipoBasquet("Equipo E", DateTime.Parse("05/11/2019"));
            arrayEquiposBasquet[2] = new EquipoBasquet("Equipo F", DateTime.Parse("06/11/2019"));

            arrayEquiposFutbol[0] = new EquipoFutbol("Equipo A", DateTime.Parse("01/11/2019"));
            arrayEquiposFutbol[1] = new EquipoFutbol("Equipo B", DateTime.Parse("02/11/2019"));
            arrayEquiposFutbol[2] = new EquipoFutbol("Equipo C", DateTime.Parse("03/11/2019"));

            Console.WriteLine(ReferenceEquals(arrayEquiposFutbol[0], null).ToString());
            Console.ReadKey();

            for (int i = 0; i <= 2; i++)
            {
                if (torneoBasquet + arrayEquiposBasquet[i])
                {
                    Console.WriteLine("Se agrego a un equipo al torneo de basquet.");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar un equipo al torneo de basquet.");
                }
            }

            for (int i = 0; i <= 2; i++)
            {
                if (torneoFutbol + arrayEquiposFutbol[i])
                {
                    Console.WriteLine("Se agrego a un equipo al torneo de futbol.");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar un equipo al torneo de futbol.");
                }
            }
            */
            Console.ReadKey();
        }
    }
}
