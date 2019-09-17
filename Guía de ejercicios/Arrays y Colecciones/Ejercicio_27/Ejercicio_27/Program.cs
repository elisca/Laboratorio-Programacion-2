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
            List<int> listaNums = new List<int>();
            Queue<int> colaNums = new Queue<int>();
            Stack<int> pilaNums = new Stack<int>();

            #region Generar_Numeros
            for (int i = 0; i < LONG_ARRAY; i++)
            {
                do
                {
                    auxNum = rndNum.Next(-100, 100);
                } while (auxNum == 0);

                listaNums.Add(auxNum);
                colaNums.Enqueue(auxNum);
                pilaNums.Push(auxNum);
            }
            #endregion

            #region Muestreo_Lista
            Console.WriteLine("LISTA DE NÚMEROS SIN ORDENAR:");
            MostrarLista(listaNums, 0);

            Console.WriteLine("NÚMEROS POSITIVOS ORDENADOS DESCENDENTEMENTE:");
            OrdenarLista(listaNums, false);
            MostrarLista(listaNums, 1);

            Console.WriteLine("NÚMEROS NEGATIVOS ORDENADOS ASCENDENTEMENTE:");
            OrdenarLista(listaNums, true);
            MostrarLista(listaNums, -1);
            Console.ReadKey();
            #endregion

            Console.Clear();

            #region Muestreo_Cola
            Console.WriteLine("COLA DE NÚMEROS SIN ORDENAR:");
            MostrarCola(colaNums, 0);

            Console.WriteLine("NÚMEROS POSITIVOS ORDENADOS DESCENDENTEMENTE:");
            OrdenarCola(colaNums, false);
            MostrarCola(colaNums, 1);

            Console.WriteLine("NÚMEROS NEGATIVOS ORDENADOS ASCENDENTEMENTE:");
            OrdenarCola(colaNums, true);
            MostrarCola(colaNums, -1);
            Console.ReadKey();
            #endregion

            Console.Clear();

            #region Muestreo_Pila
            Console.WriteLine("PILA DE NÚMEROS SIN ORDENAR:");
            MostrarPila(pilaNums, 0);

            Console.WriteLine("NÚMEROS POSITIVOS ORDENADOS DESCENDENTEMENTE:");
            OrdenarPila(pilaNums, false);
            MostrarPila(pilaNums, 1);

            Console.WriteLine("NÚMEROS NEGATIVOS ORDENADOS ASCENDENTEMENTE:");
            OrdenarPila(pilaNums, true);
            MostrarPila(pilaNums, -1);
            Console.ReadKey();
            #endregion
        }

        #region Funciones_Lista
        static void MostrarLista(List<int> listaNums, int mostrarRangos)
        {
            foreach (int auxNum in listaNums)
            {
                if ((mostrarRangos < 0 && auxNum < 0) || (mostrarRangos==0) || (mostrarRangos>0 && auxNum > 0))
                {
                    Console.Write("{0} ", auxNum);
                }
            }
            Console.WriteLine("");
        }

        static void OrdenarLista(List<int> listaNums, bool ordenAscendente)
        {
            listaNums.Sort();
            if (!ordenAscendente)
            {
                listaNums.Reverse();
            }
        }
        #endregion

        #region Funciones_Cola
        static void MostrarCola(Queue<int> colaNums, int mostrarRangos)
        {
            foreach (int auxNum in colaNums)
            {
                if ((mostrarRangos < 0 && auxNum < 0) || (mostrarRangos == 0) || (mostrarRangos > 0 && auxNum > 0))
                {
                    Console.Write("{0} ", auxNum);
                }
            }
            Console.WriteLine("");
        }

        static void OrdenarCola(Queue<int> colaNums, bool ordenAscendente)
        {
            List<int> auxListaNums;
            
            auxListaNums = colaNums.ToList();
            auxListaNums.Sort();

            if (!ordenAscendente)
            {
                auxListaNums.Reverse();
            }

            colaNums.Clear();

            foreach (int auxNum in auxListaNums)
            {
                colaNums.Enqueue(auxNum);
            }
        }
        #endregion

        #region Funciones_Pila
        static void MostrarPila(Stack<int> pilaNums, int mostrarRangos)
        {
            foreach (int auxNum in pilaNums)
            {
                if ((mostrarRangos < 0 && auxNum < 0) || (mostrarRangos == 0) || (mostrarRangos > 0 && auxNum > 0))
                {
                    Console.Write("{0} ", auxNum);
                }
            }
            Console.WriteLine("");
        }

        static void OrdenarPila(Stack<int> pilaNums, bool ordenAscendente)
        {
            List<int> auxListaNums;

            auxListaNums = pilaNums.ToList();
            auxListaNums.Sort();

            if (ordenAscendente)
            {
                auxListaNums.Reverse();
            }

            pilaNums.Clear();

            foreach (int auxNum in auxListaNums)
            {
                pilaNums.Push(auxNum);
            }
        }
        #endregion
    }
}
