using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_Recursividade
{
    class Program
    {
        /*Faça um programa para calcular a potencia de um número. O método recursivo deve receber como parâmetro a base e 
        o expoente, e devolver o valor da potência.
        EX: double CalculaPotencia (int p_base, int p_expoente)
        CalculaPotencia (2,3) = 8*/

        static double CalculaPotencia(int valor_base, int valor_expoente)
        {
            if (valor_expoente == 0)
                return 1;

            else if (valor_expoente > 0)
            {
                return valor_base * CalculaPotencia(valor_base, valor_expoente - 1);
            }

            else
                return valor_base;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculaPotencia(3,4));
            Console.ReadKey();
        }
    }
}
