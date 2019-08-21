using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(3);
            long num1 = 10, num2 = 20, resultado = 0;
            string strN1 = "10", strN2 = "20", strResultado = "0";

            Console.WriteLine("Cantidad de sumas: {0}", (int)s1);

            resultado = s1.Sumar(num1, num2);
            strResultado = s1.Sumar(strN1, strN2);

            Console.WriteLine("Resultado numérico: {0}", resultado);
            Console.WriteLine("Resultado texto: {0}", strResultado);
            Console.WriteLine("Cantidad de sumas: {0}", (int)s1);
            Console.WriteLine("Cantidad de sumas a 3 en un nuevo sumador: {0}", (int)s2);
            Console.WriteLine("Suma de cantidades de suma entre s1 y s2: {0}", s1 + s2);
            Console.WriteLine("Comparación de sumadores con distinta cantidad de sumas: {0}", s1 | s2);
            resultado = s1.Sumar(num1, num2);
            Console.WriteLine("Comparación de sumadores con igual cantidad de sumas: {0}", s1 | s2);
            Console.ReadKey();
        }
    }
}
