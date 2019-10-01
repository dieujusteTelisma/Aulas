using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número e exiba o seu sucessor.
            int x, sucessor = 0;

            Console.WriteLine("Digite um número inteiro.");
            x = int.Parse(Console.ReadLine());

            sucessor = x;
            sucessor = sucessor + 1;
           

            Console.WriteLine("O sucessor de " + x + " é  " + sucessor);
            Console.ReadKey();
        }
    }
}
