using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;
            // vou criar um metodo para colocar esse
            //Console.WriteLine("--------------");
            // Console.WriteLine("Seja bem vindo");
            //Console.WriteLine("--------------");

            //  Console.WriteLine("Vamos conversar? sim(1) nao (2)");
            // var resposta = Console.ReadKey().KeyChar.ToString();
            //  int resposta = int.Parse(Console.ReadKey().KeyChar.ToString());

            // eu deveria informar o um como string para noa fazer assim vou converstir o codigo em inteiro
            //while (resposta == "1")
            //  while (resposta == 1)
            while (AskToContinue() == 1)
            {
                // vou criar um metodo para 
                // Console.WriteLine("Vamos conversar? sim(1) nao (2)");

                //  resposta = int.Parse(Console.ReadKey().KeyChar.ToString());

                // AskToContinue()/
                nome = AskToName();
                //DateINfo();
                idade = DateINfo(nome);
            }

            Console.WriteLine($"Suas informacoes : nome {nome} e sua idade {idade}");
            Console.ReadKey();
        }

        private static void ShowInitAppText()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine("--------------");
        }

        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) nao (2)");

            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }

        private static int DateINfo(string nome)
        //private static void DateINfo()
        {

            Console.WriteLine("Qual é a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            { 
                Console.WriteLine($"{nome} pode beber cerveja");
            }
            else
            {
                Console.WriteLine($"{nome} Voce nao pode beber cerveja");
            }

            return idade;
        }

        private static string AskToName()
        {
            Console.WriteLine("Qual é o seu nome");
            return Console.ReadLine();
        }
    }
}
