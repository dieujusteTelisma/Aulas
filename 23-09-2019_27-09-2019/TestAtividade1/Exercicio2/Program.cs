using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Iniciando o programa
            Console.WriteLine("Qual é o seu nome!");
            var nome = Console.ReadLine();
            Console.WriteLine($" Bem vindo ao treinamento da HBSIS: {nome} ");
            Console.ReadKey();

        }
    }
}
