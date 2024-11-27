using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class CategoriaDeFilme
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R): ");
            string classificacao = Console.ReadLine().ToUpper();
            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Livre para todas as idades");
                    break;

                case "PG":
                    Console.WriteLine("Maior de 10 anos");
                    break;

                case "PG-13":
                    Console.WriteLine("Maior de 13 anos");
                    break;

                case "R":
                    Console.WriteLine("Maior de 18 anos");
                    break;

                default:
                    Console.WriteLine("Classificação inválida");
                    break;

            }
        }
    }
}
