using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.
            string Nome; //Variável que armazena o nome do Usuário.

            Console.Write("Informe o seu nome: ");
            Nome = Console.ReadLine();

            //Console.WriteLine(string.Format("Meu nome é: {0}", Nome));
            //Console.WriteLine("Meu nome é: " + Nome);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Meu nome é: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Nome);
            Console.ReadKey();
        }

    }
}
