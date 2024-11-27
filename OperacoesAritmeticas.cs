using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class OperacoesAritmeticas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador desejado (+, -, *, /): ");
            char operador = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    Console.WriteLine("O resultado é: " + (numero1 + numero2));
                    break;

                case '-':
                    Console.WriteLine("O resultado é: " + (numero1 - numero2));
                    break;

                case '*':
                    Console.WriteLine("O resultado é: " + (numero1 * numero2));
                    break;

                case '/':
                    if (numero2 != 0)
                    {
                        Console.WriteLine("O resultado é: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine("Divisão por zero não é permitida");
                    }
                    break;

                default:
                    Console.WriteLine("Operador inválido. Por favor use apenas +, -, * ou /.");
                    break;
            }
        }
    }
}