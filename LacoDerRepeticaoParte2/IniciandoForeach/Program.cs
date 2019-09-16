using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // IniciandoForeach01();
            // ForeachComSplit();
            // ForeachComSplitt();
            ForeachComSplitLista();
            
        }
        private static void IniciandoForeach01()

        {

            Console.WriteLine("Informar o texto: ");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e') // este é se aparecer e ele pular e continua mostrando outra letra 
                    continue;

                Console.WriteLine(item);

            }
            Console.ReadKey();


        }


        private static void ForeachComSplit()
        {

            var conteudoDotexto = "Aqui vou colocar men nome Felipe para realizar a busca";

            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var ConteudoDoTextoSplit = conteudoDotexto.Split();

            foreach (var item in ConteudoDoTextoSplit)


            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso");
            }
            Console.ReadKey();
        }

        /// <summary> metodo de busca com split e informando o nome
        /// 
        /// </summary>
        private static void ForeachComSplitt()
        {
            Console.WriteLine("Inform your name: ");
            var nome = Console.ReadLine();

            var conteudoDotexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe; vamos; colocar; isto; {nome}; para; depois; usar; com; o; replace";

            // eu poderia colocar console.readline() no lugal do nomeporque nao precisaria criar uma var nome
            // ex: amos; colocar; isto; console.readline(); para; depo
            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var ConteudoDoTextoSplit = conteudoDotexto.Split(';');

            foreach (var item in ConteudoDoTextoSplit)

            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso");
            }

            Console.WriteLine(conteudoDotexto.Replace(";", " "));
            Console.ReadKey();
        }

        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Euseblo,dade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuarios cadastrados no sistema");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
                // Console.WriteLine(item.Split(',')[1]);
            }

            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"o {nome} esta com {idade} anos de idade.");
                   
                }
            }

            Console.ReadKey();

        }

    }
}
