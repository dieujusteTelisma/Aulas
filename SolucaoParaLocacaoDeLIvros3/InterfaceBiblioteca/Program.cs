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
            /* livros.AddLivro(new Livro()
              {
                  Nome = "Riachsond"

              });

              livros
                  .GetLivros()
                  .ToList<Livro>()
                  .ForEach //
                  (x => Console.WriteLine($"Nome {x.Nome} e Idade "));

              Console.ReadKey();*/



              //1- Colocar console app para statar o projetot : set as start up ptojet
              //2- Adicionar referencia Catalogo de celulares 
              //3- Adicionar Entity mem nosso projeto Ex; tools nuget package Manager - manage nuget package 
              //4 Adicionar using ao osso projeto MOdelo , controller 
              // static CelularesController celulares = new CelularesController();
              //static void Main(string[] args)
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
                          //caso fo opcao 1 ele inseri celular 
                          case 1:
                              InserirLivro();
                              break;
                        case 2:
                            //Realiza a chamada do menu de listagem de livros
                            AtualizarLivro;
                            break;
                        case 3:
                            //Metodo que inicializa a tela de adocionar um livro
                            AdicionarLivro();
                            break;
                        case 4:
                            //Metodo que inicializa a tela de adocionar um usuário 
                            AdicionarUsuario();
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
              Console.WriteLine("Informe a Marca do celular");
              var nome = Console.ReadLine();

              Console.WriteLine("Informe o Modelo do celular ");
              //obtemos o modelo do aparelho 
              var tipo = Console.ReadLine();
              //obtemos o valor do aparelho 
              Console.WriteLine("nforme o preco do aparelho");

              var preco = double.Parse(Console.ReadLine());
              // criamos o resultado para identificar sucesso ou erro
              var resultado = livros// Nossa controler pelo nome 
                                    //que demos a ela 
                  .InserirLivro(new Livro()// um novo celular 
                  {
                      Nome = nome,

                          //  Preco = preco

                      });

              if (resultado)
                  Console.WriteLine("Celular cadastrado com sucesso!");
              else // caso false apresenta o aviso
                  Console.WriteLine("Erro ao cadastrar aparelho!");

            Console.ReadKey();


          }
        //Atualizar 
        public static void AtualizarLivro()
        {
            //apresentamos a teça em que estamos
            Console.WriteLine("--Atualizar Celular --");

            ListarLivro();
            //informamos ao usuario que ele precisa colocar o id para realizar a lateracao
            Console.WriteLine("Informe o Id para alteracao de registro");
            //obtemos o id informado
            var celularId = int.Parse(Console.ReadLine());

            //obtemos do banco o item completo que vamos atualizar
            var livro = livros //banco de dados 
                .GetLivros()//obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId); // regra para obter o celular 

            if (livros == null)
            {
                //informo que eese id nao encontrou um registro 
                Console.WriteLine("Id informado invalido");
                return;
            }


            Console.WriteLine("Informe a Marca do celular");
            //obtemos a marca do usuario 
            livro.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular ");
            //obtemos o modelo do aparelho 
            livro.Tipo = Console.ReadLine();
            //obtemos o valor do aparelho 
            Console.WriteLine("nforme o preco do aparelho");

            livro.Preco = double.Parse(Console.ReadLine());
            var resultado = livros. // Nossa controller
                AtualizarLivro(livro);//Metodo que atualiza o celular 
            if (resultado)
                Console.WriteLine("Celular atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar aparelho");
        }
        //remover 

       
        public static void  ListarLivro()
        {
            //listamos aqui par identifp item que vamos alterar 
            Console.WriteLine("--Listar Celular ");
            //listamos aqui par identificar p item que vamos alterar 
            livros.GetLivros()// Obtemos a lista de celulares
                .ToList<Livro>()// Convertemos para uma lista em memoria 
                .ForEach(x => // laco de repeticao para mostrar cada celular 
                //mostramos no console nosso celular 
                Console.WriteLine($"Id:{x.Id} Marca:{x.Nome} Modelo:{x.Tipo} Preço:{x.Preco}"));
            Console.ReadKey();
            Console.Clear();
        }
    }
      /*

                  ---------------------------------------------------------------------------------------------
          class Program
          {
              //Instanciamos "Carregamos para memoria" nosso controlador dos livros
              static LivrosController livrosController = new LivrosController();

              //Instanciamos "Carregamos para memoria" nosso controlador dos usuarios
              static UsuarioController usuarioController = new UsuarioController();

              static void Main(string[] args)
              {
                  Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                  //Aqui realizamos a tela de login do nosso sistema
                  while (!RealizaLoginSistema())
                      Console.WriteLine("Login e senha inválidos");

                  //Realizamos a chamada "invok" do nosso menu do sistema em um metodo
                  MostraMenuSistema();
              }
              /// <summary>
              /// Mostra no console o menu  disponivel do sistema.
              /// </summary>
              private static void MostraMenuSistema()
              {
                  //Iniciamos nossa variavel com o menot valor de int possivel
                  var menuEscolhido = int.MinValue;
                  //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
                  while (menuEscolhido != 0)
                  {
                      Console.Clear();
                      Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                      //Mostra as opções de menu dentro do nosso sistema.
                      Console.WriteLine("Menu sistema");
                      Console.WriteLine("1 - Listar Usuários");
                      Console.WriteLine("2 - Listar Livros");
                      Console.WriteLine("3 - Cadastrar Livro");
                      Console.WriteLine("4 - Cadastra Usuário");
                      Console.WriteLine("5 - Remover Usuário");
                      Console.WriteLine("6 - Remover Livro");
                      Console.WriteLine("7 - Trocar Usuário");
                      Console.WriteLine("0 - Sair");

                      //Aqui vamos pegar numero digitado
                      menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                      //Executar proxima funcao
                      switch (menuEscolhido)
                      {
                          case 1:
                              //Realiza a chamada do menu de listagem de usuarios
                              MostrarUsuarios();
                              break;
                          case 2:
                              //Realiza a chamada do menu de listagem de livros
                              MostrarLivro();
                              break;
                          case 3:
                              //Metodo que inicializa a tela de adocionar um livro
                              AdicionarLivro();
                              break;
                          case 4:
                              //Metodo que inicializa a tela de adocionar um usuário 
                              AdicionarUsuario();
                              break;
                          case 5:
                              //Metodo  que inicializa a tela para remover um usuário
                              RemoverUsuarioPeloID();
                              break;
                          case 6:
                              //Metodo que remove os  livros de nossa lista
                              RemoverLivroPeloID();
                              break;
                          case 7:
                              while (!RealizaLoginSistema())
                                  Console.WriteLine("Login e senha inválidos");
                              break;
                          default:
                              break;
                      }
                  }
              }
              /// <summary>
              /// Metodo que realiza a remoção do livro dentro do sistema
              /// </summary>
              private static void RemoverLivroPeloID()
              {
                  Console.WriteLine("Remover um livro pelo id no sistema");

                  MostrarLivro();

                  Console.WriteLine("Informe o ID para desativar do sistema:");
                  var livroID = int.Parse(Console.ReadLine());

                  livrosController.RemoverLivroPorId(livroID);

                  Console.WriteLine("Livro removido com sucesso!");
                  Console.ReadKey();
              }
              /// <summary>
              /// Metodo que remove os usuarios pelo o ID informado pelo usuario 
              /// </summary>
              private static void RemoverUsuarioPeloID()
              {
                  Console.WriteLine("Remover um usuario pelo id no sistema");
                  //Metodo que mostra os usuarios criado anteriomente assim facilitando 
                  //o usuario informar o ID correto para desativar 
                  MostrarUsuarios();

                  Console.WriteLine("Informe o ID para desativar do sistema:");
                  var usuarioID = int.Parse(Console.ReadLine());

                  //Aqui chamamos RemoverUsuarioPorID da nossa classe que controla os usuarios do sistema
                  usuarioController.RemoverUsuarioPorID(usuarioID);

                  //Informamos que o usuario foi desativado com sucesso.
                  Console.WriteLine("Usuário desativado com sucesso");
                  Console.ReadKey();
              }
              /// <summary>
              /// Metodo que adiciona um novo usuario no sistema pelo console
              /// </summary>
              private static void AdicionarUsuario()
              {
                  Console.WriteLine("Cadastrar usuário dentro do sistema!");

                  Console.WriteLine("Informe um Login:");
                  var loginUsuario = Console.ReadLine();

                  Console.WriteLine("informe uma senha:");
                  var senhaUsuario = Console.ReadLine();

                  usuarioController.AdicionarUsuario(new Usuario()
                  {
                      Login = loginUsuario,
                      Senha = senhaUsuario
                  });

                  Console.WriteLine("Usuário cadastrado com sucesso!");
                  Console.ReadKey();
              }
              /// <summary>
              /// Metodo que adiciona dentro de nossa lista um novo registro de livro
              /// </summary>
              private static void AdicionarLivro()
              {
                  //Identificamos que o mesmo esta na parte de cadas,tro de livros do sistema
                  Console.WriteLine("Cadastrar livro dentro do sistema!");
                  //Informamos que para dar continuidade ele deve informar um nome para o livro
                  Console.WriteLine("Nome do livro para cadastro:");
                  //Obtemos esta informação do usuario
                  var nomeDoLivro = Console.ReadLine();
                  //"livrosController" livros controle e nosso "objeto" em memoria
                  //Com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
                  //como adicionar um item a nossa lista de livros
                  livrosController.AdicionarLivro(new Livro()
                  {
                      //Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
                      //com o sinal de apenas um "=" temos atribuição, passagem de valor
                      Nome = nomeDoLivro
                  });
                  //Indico que finalizamos o processo de cadastro do livro, assim o usuario já sabe 
                  //que o mesmo foi realizado e sem erros
                  Console.WriteLine("Livro cadastrado com sucesso!");
                  //ReadKey apenas para que ele visualize esta informação
                  Console.ReadKey();
              }
              /// <summary>
              /// Metodo para mostrar a lista de usuarios já cadastrados no sistema
              /// </summary>
              private static void MostrarUsuarios()
              {
                  //Aqui andamos pela lista de usuarios e mostramos ela no console
                  usuarioController.RetornaListaDeUsuarios().ForEach(i =>
                  Console.WriteLine($"Id: {i.Id} Login usuário:{i.Login}"));

                  Console.ReadKey();
              }
              /// <summary>
              /// Metodo que mostra os livros já cadastrados em nossa lista
              /// </summary>
              private static void MostrarLivro()
              {
                  livrosController.RetornaListaDeLivros().ForEach(i =>
                  //Para cada livro cadastrado temos a demostração no console por esta parte
                  Console.WriteLine($"Id {i.Id} Nome do livro:{i.Nome}"));

                  Console.ReadKey();
              }

              /// <summary>
              /// Metodo que realiza os procedimento complestos de login dentro do 
              /// sistema como solicitação de login e senha pelo console assim como a 
              /// respectivas validações que o mesmo precisa para entrar no sistema
              /// </summary>
              /// <returns>Retorna verdadeiro quando o login e senha informados
              /// estiverem corretos.</returns>
              private static bool RealizaLoginSistema()
              {
                  Console.Clear();
                  //Informamos o que é preciso para entrar no sistema
                  Console.WriteLine("Informe seu login e senha para acessar o sistema:");

                  //Informamos no console que precisamos do Login do usuario
                  Console.WriteLine("Login:");
                  //Solicitamos o login
                  var loginDoUsuario = Console.ReadLine();

                  //Informamos no console que precisa da senha
                  Console.WriteLine("Senha:");
                  //Solicitamos a senha do usuario
                  var senhaDoUsuario = Console.ReadLine();

                  //Validamos o login de maneira duvidosa
                  return usuarioController.LoginSistema(new Usuario()
                  {
                      Login = loginDoUsuario,
                      Senha = senhaDoUsuario
                  });

                                                                            */
        }
    }
}
