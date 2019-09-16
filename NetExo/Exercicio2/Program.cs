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
            //Crie um algoritmo que verifique se um número informado é par ou impar
            int n = 0;
            int r = 0;
            Console.WriteLine("Determina se o número é par ou impar");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;
            if (r == 1)
            {
                Console.WriteLine("O número informado é impar");
                Console.WriteLine("Informe um outro numero");
                
            }
            else
            {
                Console.WriteLine("O número informado é par");
            }
            Console.ReadKey();
        }
    }
}
