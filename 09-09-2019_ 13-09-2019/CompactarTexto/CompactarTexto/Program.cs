using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto  = "Oi meu nome Webster vontade Fever e logo vontade eu Webster tenho vontade de falar muito idioma ";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"texto contem : { primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("Webster", "1").Replace("vontade", "2");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"texto contem : { primeiroTexto.Length} caracteres.");
            Console.ReadKey();

        }
    }
}
