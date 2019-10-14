using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {

        static LivrosController livros = new LivrosController();
        static void Main(string[] args)
        {

            {
                //definimos uma opcao de menu inicial 
                var opcao = int.MinValue;
                //definimos que emquanto for diferente de 0
                //ele continua em nosso loop
                while (opcao != 0)
                {
                    //Apresentacao do menu inicial
                    Console.WriteLine("Escolha um nenu");
                    Console.WriteLine("1- inserir Livro");
                    Console.WriteLine("2- Atualizar Livro");
                    Console.WriteLine("3- Remover Livro");
                    Console.WriteLine("4- Listar Livro ");
                    Console.WriteLine("0 - Sair");
                    //obtemos o menu escolhido pelo usuario 

                    opcao = int.Parse(Console.ReadLine());
                    //switch nos ajuda com a escolha da opcao 
                    switch (opcao)
                    {
                        //caso fo opcao 1 ele inseri livro
                        case 1:
                            InserirLivro();
                            break;
                        case 2:
                            //Ayualizar a lista de livros
                            AtualizarLivro();
                            break;
                        case 3:
                            //Remover livros
                            RemoverLivro();
                            break;
                        case 4:
                            //Realiza a chamada do menu de listagem de livros
                            ListarLivro();
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


        }
        public static void InserirLivro()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Inserir Livro --");
            Console.WriteLine("Informe o livro ");
             var nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo de livro ");
            //obtemos o modelo do aparelho 
           var  tipo = Console.ReadLine();
            //obtemos o valor do aparelho 
            Console.WriteLine("nforme o preco do livro");

            var preco = double.Parse(Console.ReadLine());
            // criamos o resultado para identificar sucesso ou erro
            var resultado = livros// Nossa controler pelo nome 
                                  //que demos a ela 
                .InserirLivro(new Livro()// um novo celular 
                {
                    Nome = nome,
                    Tipo = tipo,
                    Preco = preco

                });

            if (resultado)
                Console.WriteLine("livro cadastrado com sucesso!");
            else // caso false apresenta o aviso
                Console.WriteLine("Erro ao cadastrar um livro!");

            Console.ReadKey();


        }
        //Atualizar 
        public static void AtualizarLivro()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Atualizar livro  --");

            ListarLivro();
            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao
            Console.WriteLine("Informe o Id para alteracao de registro");
            //obtemos o id informado
            var livroId = int.Parse(Console.ReadLine());

            //obtemos do banco o item completo que vamos atualizar
            var livro = livros //banco de dados 
                .GetLivros()//obtemos os livros
                .FirstOrDefault(x => x.Id == livroId); // regra para obter o livro

            if (livros == null)
            {
                //informo que eese id nao encontrou um registro 
                Console.WriteLine("Id informado invalido");
                return;
            }


            Console.WriteLine("Informe a mome do livro");
            //obtemos a marca do usuario 
            livro.Nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do livro ");
            //obtemos o modelo do aparelho 
            livro.Tipo = Console.ReadLine();
            //obtemos o valor do aparelho 
            Console.WriteLine("nforme o preco do livro");

            livro.Preco = double.Parse(Console.ReadLine());
            var resultado = livros. // Nossa controller
                AtualizarLivro(livro);//Metodo que atualiza o celular 
            if (resultado)
                Console.WriteLine("Livro atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar um livro");
        }
        //remover 
        public static void RemoverLivro()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Remover Celular --");

            ListarLivro();
            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao
            Console.WriteLine("Informe o Id para alteracao de registro");
            //obtemos o id informado
            var livroId = int.Parse(Console.ReadLine());

            var resultado = livros. // Nossa controller
              RemoverLivro(livroId);//Metodo que atualiza o celular 
            if (resultado)
                Console.WriteLine("Livro removido com sucesso!");
            else
                Console.WriteLine("Erro ao remover  Livro");

            Console.ReadKey();
            Console.Clear();
        }

        public static void ListarLivro()
        {
            //listamos aqui par identifp item que vamos alterar 
            Console.WriteLine("--Listar Livros ");
            //listamos aqui par identificar p item que vamos alterar 
            livros.GetLivros()// Obtemos a lista de celulares
                .ToList<Livro>()// Convertemos para uma lista em memoria 
                .ForEach(x => // laco de repeticao para mostrar cada celular 
                //mostramos no console nosso celular 
                Console.WriteLine($"Id:{x.Id} Nome:{x.Nome} Tipo:{x.Tipo} Preço:{x.Preco}"));
            Console.ReadKey();
            Console.Clear();
        }
    }
}

