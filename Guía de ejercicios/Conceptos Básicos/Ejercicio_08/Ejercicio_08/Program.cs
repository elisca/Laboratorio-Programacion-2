using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            uint valorHora=0, antiguedad=0, horasTrabajadas=0;
            float totalNeto=0, totalBruto=0, totalDescuentos=0;
            string nombre;
            char ingresarOtro='s';

            do
            {
                Console.Clear();
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                do
                {
                    Console.Write("Valor hora: ");
                } while (!uint.TryParse(Console.ReadLine(), out valorHora) || valorHora<0);
                
                do
                {
                    Console.Write("Antiguedad (en años): ");
                }while(!uint.TryParse(Console.ReadLine(), out antiguedad) || antiguedad<0);

                do
                {
                    Console.Write("Horas mensuales trabajadas: ");
                }while(!uint.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas<0);

                totalBruto = valorHora * horasTrabajadas + antiguedad * 150;
                totalDescuentos = totalBruto * 0.13f;
                totalNeto = totalBruto - totalDescuentos;

                Console.Clear();
                Console.WriteLine("Empleado: {0}", nombre);
                Console.WriteLine("Valor hora: ${0} Horas trabajadas: {1} Antiguedad (en años): {2}", valorHora, horasTrabajadas, antiguedad);
                Console.WriteLine("Total bruto: ${0} Total descuentos: ${1} Total neto: ${2}", totalBruto, totalDescuentos, totalNeto);
                Console.ReadKey();

                Console.Clear();
                do
                {
                    Console.Write("¿Ingresar otro empleado? (s/n): ");
                }while(!char.TryParse(Console.ReadLine(), out ingresarOtro) || (ingresarOtro!='s' && ingresarOtro!='S' && ingresarOtro!='n' && ingresarOtro!='N'));
            }while (ingresarOtro == 's' || ingresarOtro == 'S');
        }
    }
}
