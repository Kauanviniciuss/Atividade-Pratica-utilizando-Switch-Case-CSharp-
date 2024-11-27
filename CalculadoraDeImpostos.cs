using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class CalculadoraDeImpostos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            double imposto;

            switch (salario)
            {
                case <= 1500:
                    imposto = salario * 0.05; 
                    Console.WriteLine($"Imposto devido: R${imposto:F2}");
                    break;
                case > 1500 and <= 3000:
                    imposto = salario * 0.10; 
                    Console.WriteLine($"Imposto devido: R${imposto:F2}");
                    break;
                case > 3000:
                    imposto = salario * 0.15; 
                    Console.WriteLine($"Imposto devido: R${imposto:F2}");
                    break;
                default:
                    Console.WriteLine("Erro: valor inválido.");
                    break;
            }
        }
    }
}