using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inform a Word");

            string word = Console.ReadLine();

            if (word.Length >= 2)
            {
                Console.WriteLine(word[0] + "..." + word[word.Length - 1]);
                
            }
            
            Console.ReadKey();




        }
    }
}





