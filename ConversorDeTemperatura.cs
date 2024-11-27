using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    internal class ConversorDeTemperatura
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha a conversão que deseja:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine(celsius + "°C é igual a " + fahrenheit + "°F");
                    break;

                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine(fahrenheit + "°F é igual a " + celsius + "°C");
                    break;

                default:
                    Console.WriteLine("Essa opção não existe. Escolha 1 ou 2.");
                    break;
            }
        }
    }
}