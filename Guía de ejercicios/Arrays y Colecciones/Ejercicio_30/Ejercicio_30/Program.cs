using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia abuDhabi = new Competencia(10, 3);
            AutoF1[] autos = new AutoF1[4];

            autos[0] = new AutoF1(1, "Mc Laren Mercedes");
            autos[1] = new AutoF1(1, "Ferrari");
            autos[2] = new AutoF1(1, "Red Bull Racing");
            autos[3] = new AutoF1(1, "India Forces");

            Console.WriteLine("{0}", abuDhabi.MostrarDatos());

            foreach (AutoF1 auxAutoF1 in autos)
            {
                if (abuDhabi + auxAutoF1)
                {
                    Console.WriteLine("Se pudo agregar un auto a la competencia.");
                    Console.WriteLine("{0}", auxAutoF1.MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se pudo agregar un auto a la competencia.");
                    Console.WriteLine("{0}", auxAutoF1.MostrarDatos());
                }
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
