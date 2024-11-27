using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class CalculadoraDeFatorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
                return;
            }

            int fatorial = 1;

            if (numero == 0)
            {
                fatorial = 1;
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }
            }

            Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
        }
    }
}

