using InsercaoDeinformacoesDeUma.Controller;
using InsercaoDeinformacoesDeUma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceListagemDeFlores
{
    class Program
    {
        static FloreController flores = new FloreController();
        static void Main(string[] args)
        {
            //definimos uma opcao de menu inicial 
            var opcao = int.MinValue;
            //definimos que emquanto for diferente de 0
            //ele continua em nosso loop
            while (opcao != 0)
            {
                //Apresentacao do menu inicial
                Console.WriteLine("Escolha um nenu");
                Console.WriteLine("1- inserir Flores");
                Console.WriteLine("2- Mostrar Flores");
                Console.WriteLine("3- Remover FLores");
                Console.WriteLine("4- Listar Flores ");
                Console.WriteLine("0 - Sair");
                //obtemos o menu escolhido pelo usuario 

                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a escolha da opcao 
                switch (opcao)
                {
                    //caso fo opcao 1 ele inseri celular 
                    case 1:
                        InsertFlor();
                      

                       break;
                    case 2:
                        MostrarFlores();


                        break;
                    case 0:
                        //informamos que estamos saindo do sistema
                        Console.WriteLine("saindo do sistema");
                        break;
                    default://Caso colocar uma opcao nao valida 
                        Console.WriteLine("opcao invalida");
                        break;
                }
                //Colocamos true para informar que nao deve aparecer 
                //tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
            }
        }

        //inserir 
        public static void InsertFlor()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Inserir FLor --");
            Console.WriteLine("Informe o nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade");
            var quantidade = int.Parse(Console.ReadLine());

          
            // criamos o resultado para identificar sucesso ou erro
            var resultado = flores// Nossa controler pelo nome 
                                  //que demos a ela 
                .InsertFlor(new Flore()// um novo celular 
                {
                    Nome = nome,
                    Quantidade = quantidade

                  

                });

            if (resultado)
                Console.WriteLine("Flor cadastrado com sucesso!");
            else // caso false apresenta o aviso
                Console.WriteLine("Erro ao cadastrar FLor!");

            Console.ReadKey();
            Console.Clear();

            
        }
          public static void MostrarFlores()
            {
            flores.GetFlore().OrderByDescending(x => x.Quantidade).ToList<Flore>().ForEach(x => Console.WriteLine($"Nome : {x.Nome} Quantidade: {x.Quantidade}"));
            var total = flores.GetFlore().Sum(x => x.Quantidade);
            Console.WriteLine($"A soma total de flores é : {total}");
            Console.WriteLine("");
            Console.ReadKey();
                
          }
        

    }
}