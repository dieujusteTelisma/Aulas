using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForeachComSplitLista();
            ForeachComSplitLis();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Wrangler,marca: Jeep ,ano:2009;nome:Land Rover,marca:Lamborghini,ano:2015;nome:Touring,marca:Mercedes-Benz,ano:2019";

            var listaDeInformacoes = conteudo.Split(';');



            Console.WriteLine("Carros cadastrados no sistema");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);

            }

            Console.WriteLine("Informe o nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                //var vnomecarro = informacoesSplit[0].Split
                var nome = informacoesSplit[0].Split(':')[1];
                var marca = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];


                if (nome == nomeBusca)
                {
                    Console.WriteLine($"o {nome} é um {marca} de  {ano}.");
                    // searchName
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.ReadKey();
        }
        private static void ForeachComSplitLis()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Nomes cadastrados no sistema");

            foreach (var item in listaDeInformacoes)
            {

                var nome = item.Split(',')[0].Split(':')[1];
                var idade = item.Split(',')[1].Split(':')[1];

                if (int.Parse(idade) >= 18)

                    Console.WriteLine($" usuario : {nome} {idade} ");

            }



            Console.ReadKey();


        }

    }
}
