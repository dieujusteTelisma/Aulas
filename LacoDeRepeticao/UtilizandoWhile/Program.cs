using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;


            while (count < 1000)
            {
                Console.WriteLine($"Numero : {count}");
                count++; 
                //count += 1; este faz mesma coisa que o count++ so que posso contar em 2 em 4 etc
            }

            Console.WriteLine("terminou o loop");
            Console.ReadKey();

            // tirando o console.write ele vai muito mais rapido porque ele nao esta reagindo com o console
        }
    }
}
