using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro pelo numero de registro do sistema
            Console.WriteLine("Informe O livro a ser consultado:");

            //parte do codigo que recebe as informacoes de registro do livro e coloca na variavel 
            //numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();

            //Aqui realizado a comparacao das informacoes do livro informado com o que tenho disponivel em estoque
            if(numeroDoLivro == "123456")
            {
                //informo que este livro ja esta alocado 
                Console.WriteLine("Livro Indisponivel!!");
                Console.ReadKey();

                //Finaliza o metodo 
                return;
            }
            else
            {
                Console.WriteLine("Deseja alocar o livro? (1) sim (2) nao");

                var resposta = Console.ReadLine();
                if (resposta == "1")
                {

                    Console.WriteLine("Livro alocado.");
                    Console.ReadKey();
                    return;
                }
;           }
            Console.ReadKey();
        }
    }
}
