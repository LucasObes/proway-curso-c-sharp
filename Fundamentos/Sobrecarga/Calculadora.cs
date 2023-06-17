using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Sobrecarga
{
    internal class Calculadora
    {
        // Overload: sobrecarga de métodos, ou seja, permitir um mesmo método receber parâmetros diferentes e/ou quantidades diferentes
        // porem com o mesmo objetivo
        // usa para diferenciar: a quantidade de parâmetros, os tipos e a ordem
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        public int Somar(int numero1, int numero2, int numero3, int numero4)
        {
            return numero1 + numero2 + numero3 + numero4;
        }
    }
}
