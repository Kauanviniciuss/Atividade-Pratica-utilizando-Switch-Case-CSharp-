using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class NotaDoAluno
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a nota do aluno (0 a 10): ");
            double nota = Convert.ToDouble(Console.ReadLine());

            switch (nota)
            {
                case double n when (n >= 9 && n <= 10):
                    Console.WriteLine("Classificação: A");
                    break;

                case double n when (n >= 7 && n <= 8):
                    Console.WriteLine("Classificação: B");
                    break;

                case double n when (n >= 5 && n <= 6):
                    Console.WriteLine("Classificação: C");
                    break;

                case double n when (n >= 3 && n <= 4):
                    Console.WriteLine("Classificação: D");
                    break;

                case double n when (n >= 0 && n <= 2):
                    Console.WriteLine("Classificação: F");
                    break;

                default:
                    Console.WriteLine("Essa nota não existe, digite um valor entre 0 e 10.");
                    break;
            }
        }
    }
}