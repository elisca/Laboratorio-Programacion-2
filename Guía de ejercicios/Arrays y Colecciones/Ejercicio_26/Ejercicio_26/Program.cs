using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LONG_ARRAY = 20;

            Random rndNum = new Random();
            int auxNum;
            int[] arrayNums = new int[LONG_ARRAY];

            for (int i = 0; i < LONG_ARRAY; i++)
            {
                do
                {
                    auxNum = rndNum.Next(-100, 100);
                } while (auxNum == 0);

                arrayNums[i] = auxNum;
            }

            Console.WriteLine("ARRAY DE NÚMEROS SIN ORDENAR:");
            MostrarArray(arrayNums, 0);

            Console.WriteLine("NÚMEROS POSITIVOS ORDENADOS DESCENDENTEMENTE:");
            OrdenarArray(arrayNums, LONG_ARRAY, false);
            MostrarArray(arrayNums, 1);

            Console.WriteLine("NÚMEROS NEGATIVOS ORDENADOS ASCENDENTEMENTE:");
            OrdenarArray(arrayNums, LONG_ARRAY, true);
            MostrarArray(arrayNums, -1);
            Console.ReadKey();
        }

        static void MostrarArray(int[] arrayNums, int mostrarRangos)
        {
            foreach (int auxNum in arrayNums)
            {
                if ((mostrarRangos < 0 && auxNum < 0) || (mostrarRangos==0) || (mostrarRangos>0 && auxNum > 0))
                {
                    Console.Write("{0} ", auxNum);
                }
            }
            Console.WriteLine("");
        }

        static void OrdenarArray(int[] arrayNums, int longArray, bool ordenAscendente)
        {
            int auxSwap;
            if (arrayNums != null && longArray >= 2)
            {
                for (int i = 0; i < longArray - 1; i++)
                {
                    for (int j = i + 1; j < longArray; j++)
                    { 
                        if((arrayNums[i] > arrayNums[j] && ordenAscendente) || (arrayNums[i] < arrayNums[j] && !ordenAscendente))
                        {
                            auxSwap = arrayNums[i];
                            arrayNums[i] = arrayNums[j];
                            arrayNums[j] = auxSwap;
                        }
                    }
                }
            }
        }
    }
}
