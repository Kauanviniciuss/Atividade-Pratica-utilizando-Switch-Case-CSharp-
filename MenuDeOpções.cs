using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class MenuDeOpções { 
  

            public static void Main(string[] args)
            {
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Exibir 'Olá, Mundo!'");
                Console.WriteLine("2 - Exibir 'Bem-vindo ao C#'");
                Console.WriteLine("3 - Sair");

                int opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine(" Olá, Mundo! ");
                    break;

                case 2:
                    Console.WriteLine("Bem vindo ao C#! ");
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Essa opção não existe");
                    break;
            }
        }
    }
}
