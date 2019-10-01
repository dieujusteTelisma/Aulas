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
            string source = " I want to eat a banana.";

            // Replace one substring with another with String.Replace.
            // Only exact matches are supported.
            var replacement = source.Replace("banana", "Laranja");
            Console.WriteLine($"A frase era <{source}>");
            Console.WriteLine($"A frase agora é <{replacement}>");
            Console.ReadKey();
        }
    }
}
