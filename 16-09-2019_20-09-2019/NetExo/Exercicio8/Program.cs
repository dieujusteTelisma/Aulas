using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
            //se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual 
            //a 18 anos exiba na cor verde “Permissão concedida”.

            Processar();

            Console.ReadKey();
        }

        private static void Processar()
        {
            int Idade;
            Console.Write("Informe a sua idade: ");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso permitdo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado");
            }

        }
    }
}
