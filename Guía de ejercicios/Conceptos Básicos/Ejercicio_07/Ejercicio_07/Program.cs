using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento;
            TimeSpan diferenciaFechas = new TimeSpan();

            do
            {
                Console.Write("Fecha de nacimiento: ");
            }while(!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento) || fechaNacimiento > DateTime.Now);

            diferenciaFechas = DateTime.Now - fechaNacimiento;

            if (diferenciaFechas.Days == 1)
            {
                Console.WriteLine("Edad: {0} día.", diferenciaFechas.Days);
            }
            else
            {
                Console.WriteLine("Edad: {0} dias.", diferenciaFechas.Days);
            }
            Console.ReadKey();
        }
    }
}
