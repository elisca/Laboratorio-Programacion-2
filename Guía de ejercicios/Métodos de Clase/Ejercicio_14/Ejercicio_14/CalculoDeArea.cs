using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    internal class CalculoDeArea
    {
        internal static double CalcularCuadrado(double ladoC)
        {
            if (ladoC <= 0)
            {
                return double.MinValue;
            }
            else
            {
                return Math.Pow(ladoC, 2);
            }
        }

        internal static double CalcularTriangulo(double baseT, double alturaT)
        {
            if (baseT <= 0 || alturaT <= 0)
            {
                return double.MinValue;
            }
            else
            {
                return baseT * alturaT / 2;
            }
        }

        internal static double CalcularCirculo(double radioC)
        {
            if (radioC <= 0)
            {
                return double.MinValue;
            }
            else
            {
                return Math.PI * Math.Pow(radioC, 2);
            }
        }
    }
}
