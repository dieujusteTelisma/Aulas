using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando 
            Console.WriteLine("Qual é o seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("QUal é a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)

                Console.WriteLine($"parabens {nome} você já esta na fase adulta");
            else

                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
                Console.ReadKey();
              
        }

    }
}

