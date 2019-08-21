using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Escalas_Temperatura;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius tC = 25;
            Fahrenheit tF = 32;
            Kelvin tK = 273.15;

            Console.WriteLine("Temperaturas de cada termómetro:");
            Console.WriteLine("Term. 1: {0}ºC  Term.2: {1}ºF Term.3: {2}ºK", tC.GetCantidad(), tF.GetCantidad(), tK.GetCantidad());
            Console.WriteLine("Term. 1: {0}ºC, {1}ºF y {2}ºK", tC.GetCantidad(), ((Fahrenheit)tC).GetCantidad(), ((Kelvin)tC).GetCantidad());
            Console.WriteLine("Term. 2: {0}ºF, {1}ºC y {2}ºK", tF.GetCantidad(), ((Celsius)tF).GetCantidad(), ((Kelvin)tF).GetCantidad());
            Console.WriteLine("Term. 3: {0}ºK, {1}ºF y {2}ºC", tK.GetCantidad(), ((Fahrenheit)tK).GetCantidad(), ((Celsius)tK).GetCantidad());

            Console.WriteLine("Term. 1: {0}ºC + Term. 2: {1}ºF = {2}ºC",tC.GetCantidad(),tF.GetCantidad(),(tC+tF).GetCantidad());
            Console.WriteLine("Term. 1: {0}ºC + Term. 3: {1}ºK = {2}ºC", tC.GetCantidad(), tK.GetCantidad(), (tC + tK).GetCantidad());

            Console.ReadKey();
        }
    }
}
