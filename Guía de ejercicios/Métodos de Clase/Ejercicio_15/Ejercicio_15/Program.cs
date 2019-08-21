using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char ingresarOtro = 's', operacion=' ';
            double num1 = 0, num2 = 0, resultado = 0;

            Console.WriteLine("Cálculadora.");

            do
            {
                do
                {
                    Console.Write("Número 1: ");
                }while(!double.TryParse(Console.ReadLine(),out num1));

                do
                {
                    Console.Write("Número 2: ");
                } while (!double.TryParse(Console.ReadLine(), out num2));

                do
                {
                    Console.Write("Operación: ");
                } while (!char.TryParse(Console.ReadLine(), out operacion) || (operacion!='+' && operacion!='-' && operacion!='*' && operacion!='/'));

                resultado = Calculadora.Calcular(num1, num2, operacion);

                Console.Clear();
                Console.WriteLine("Resultado: {0}{1}{2}={3}", num1, operacion, num2, resultado);

                do
                {
                    Console.Write("¿Ingresar un nuevo cálculo? (s/n): ");
                } while (!char.TryParse(Console.ReadLine(), out ingresarOtro) || (ingresarOtro != 's' && ingresarOtro != 'S' && ingresarOtro != 'n' && ingresarOtro != 'N'));
                Console.Clear();
            } while (ingresarOtro == 's' || ingresarOtro == 'S');
        }
    }
}
