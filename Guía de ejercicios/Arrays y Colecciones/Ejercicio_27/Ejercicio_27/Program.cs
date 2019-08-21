using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndNum = new Random();
            int numAct = 0;
            byte contNumsIngresados = 0;
            int[] arrayNums = new int[20];
            List<int> listaNums = new List<int>();
            Queue<int> colaNums = new Queue<int>();
            Stack<int> pilaNums = new Stack<int>();

            do
            {
                numAct = rndNum.Next(-100, 100);
                if (numAct != 0)
                {
                    arrayNums[contNumsIngresados] = numAct;
                    contNumsIngresados++;
                }
            } while (contNumsIngresados < 20);

            #region Lista
            Console.WriteLine("Lista de números sin ordenar:");
            foreach (int auxNum in arrayNums)
            {
                listaNums.Add(auxNum);
            }

            foreach (int auxNum in listaNums)
            {
                Console.WriteLine("Número: {0}", auxNum);
            }

            listaNums.Sort();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Lista de números negativos ordenados ascendentemente:");
            foreach (int auxNum in listaNums)
            {
                if (auxNum < 0)
                {
                    Console.WriteLine("Número: {0}", auxNum);
                }
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Lista de números positivos ordenados descendentemente:");
            for (int i = listaNums.Count - 1; i >= 0; i--)
            {
                if (listaNums[i] > 0)
                {
                    Console.WriteLine("Número: {0}", listaNums[i]);
                }
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Cola
            //Copia el array de números en una cola
            foreach (int auxNum in arrayNums)
            {
                colaNums.Enqueue(auxNum);
            }

            Console.WriteLine("Cola de números sin ordenar:");
            foreach (int auxNum in colaNums)
            {
                Console.WriteLine("Número: {0}", auxNum);
            }

            //Convierte a la cola de números en una lista, ordena la misma y vuelve a cargar una cola con la lista ordenada
            listaNums = colaNums.ToList();
            listaNums.Sort();
            colaNums.Clear();

            foreach (int auxNum in listaNums)
            {
                colaNums.Enqueue(auxNum);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cola de números negativos ordenados ascendentemente:");
            foreach (int auxNum in colaNums)
            {
                if (auxNum < 0)
                {
                    Console.WriteLine("Número: {0}", auxNum);
                }
            }

            Console.ReadKey();
            Console.Clear();

            //Convierte a la cola de números en una lista, ordena la misma y vuelve a cargar una cola con la lista ordenada
            listaNums = colaNums.ToList();
            listaNums.Sort();
            listaNums.Reverse();
            colaNums.Clear();

            foreach (int auxNum in listaNums)
            {
                colaNums.Enqueue(auxNum);
            }

            Console.WriteLine("Cola de números positivos ordenados descendentemente:");
            foreach (int auxNum in colaNums)
            {
                if (auxNum > 0)
                {
                    Console.WriteLine("Número: {0}", auxNum);
                }
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Pila
            //Copia el array de números en una pila
            foreach (int auxNum in arrayNums)
            {
                pilaNums.Push(auxNum);
            }

            Console.WriteLine("Pila de números sin ordenar:");
            foreach (int auxNum in pilaNums)
            {
                Console.WriteLine("Número: {0}", auxNum);
            }

            //Convierte a la pila de números en una lista, ordena la misma y vuelve a cargar una pila con la lista ordenada
            listaNums = pilaNums.ToList();
            listaNums.Sort();
            listaNums.Reverse();
            pilaNums.Clear();

            foreach (int auxNum in listaNums)
            {
                pilaNums.Push(auxNum);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Pila de números negativos ordenados ascendentemente:");
            foreach (int auxNum in pilaNums)
            {
                if (auxNum < 0)
                {
                    Console.WriteLine("Número: {0}", auxNum);
                }
            }

            Console.ReadKey();
            Console.Clear();

            //Convierte a la pila de números en una lista, ordena la misma y vuelve a cargar una pila con la lista ordenada
            listaNums = pilaNums.ToList();
            listaNums.Sort();
            pilaNums.Clear();

            foreach (int auxNum in listaNums)
            {
                pilaNums.Push(auxNum);
            }

            Console.WriteLine("Pila de números positivos ordenados descendentemente:");
            foreach (int auxNum in pilaNums)
            {
                if (auxNum > 0)
                {
                    Console.WriteLine("Número: {0}", auxNum);
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
