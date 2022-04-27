using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculator
{
    class ModelCalculator
    {
        public ModelCalculator()
        {

        }

        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }//fim do somar

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }//fim do subtrair

        public double Dividir(double num1, double num2)
        {
            if (num2 <= 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }//fim do metodo dividir

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }//fim do multiplicar

        public double Potencia(double bas, double expoente)
        {
            if (expoente == 1)
            {
                return bas;
            }
            else if (expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }
        }//fim do metodo potencia
        public double Raiz(double num1)
        {
            if (num1 <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }
        }//fim do metodo raiz


    }

}



