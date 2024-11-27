using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class ClassificaçãoDeIdade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());

            switch (idade)
            {
                case int n when (n <= 12):
                    Console.WriteLine("Criança");
                    break;

                case int n when (n <= 17):
                    Console.WriteLine("Adolescente");
                    break;

                case int n when (n <= 59):
                    Console.WriteLine("Adulto");
                    break;

                case int n when (n <= 116):
                    Console.WriteLine("Idoso");
                    break;

                case int n when (n >= 117):
                    Console.WriteLine("Não existe essa idade");
                    break;

                default:
                    Console.WriteLine("Idade inválida.");
                    break;
            }
        }
    }
}
