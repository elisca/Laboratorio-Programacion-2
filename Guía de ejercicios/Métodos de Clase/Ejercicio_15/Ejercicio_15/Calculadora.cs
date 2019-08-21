using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double op1, double op2, char oper)
        {
            switch (oper)
            {
                case '+':
                    op1 += op2;
                    break;
                case '-':
                    op1 -= op2;
                    break;
                case '*':
                    op1 *= op2;
                    break;
                case '/':
                    if (Validar(op2) == true)
                    {
                        op1 /= op2;
                    }
                    else
                    {
                        op1 = double.MinValue;
                    }
                    break;
                default:
                    op1 = double.MinValue;
                    break;
            }
            return op1;
        }

        private static bool Validar(double op2)
        {
            if (op2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }                
        }
    }
}
