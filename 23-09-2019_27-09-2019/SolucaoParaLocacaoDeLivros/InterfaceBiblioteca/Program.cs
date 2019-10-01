
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
        static LivrosController livrosController = new LivrosController();
        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();
        }
        /// <summary>
        /// Mostra no console o menu  disponivel do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Cadastrar Usuario");
                Console.WriteLine("5 - Remover Usuario");
                Console.WriteLine("6 - Remover livro");
                Console.WriteLine("7- Fazer logof");
                Console.WriteLine("0 - Sair");
                //Aqui vamos pegar numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        MostrarUsuario();

                        break;

                    case 2:
                        MostrarLivro();
                        break;
                    case 3:
                        AdicionarLivro();
                        break;
                    case 4:
                        AdicionarUsuario();
                        break;
                    case 5:
                        RemoverUsuarioPeloID();
                             break;
                    case 6:
                        RemoverLivroPeloID();
                        break;
                    case 7:
                        Console.Clear();
                        while (!RealizaLoginSistema())
                        {
                            Console.WriteLine("Login e senha inválidos");
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover um usuario pelo id no sistema");
            //Metodo que mostra os usuarios criado anteriormente
            // o usuario informar id correto para desativar 
            MostrarUsuario();

            Console.WriteLine("Informe o ID para desativar do sistema");
            var usuarioID = int.Parse(Console.ReadLine());

            //aqui chamamos RemoverUsuarioPorID da nosssa classe que controla os usuarios do sistema
            usuarioController.RemoverUsuarioPorId(usuarioID);

            //Informamos que o usuario foi desativado com sucesso
            Console.WriteLine("Usuario desativado com sucesso");
            Console.ReadKey();
        }

        private static void RemoverLivroPeloID()
        {
            Console.WriteLine("Remover livro pelo id no sistema");
            //Metodo que mostra os usuarios criado anteriormente
            // o usuario informar id correto para desativar 
            MostrarLivro();

            Console.WriteLine("Informe o ID para desativar do sistema");
            var livroID = int.Parse(Console.ReadLine());

            //aqui chamamos RemoverUsuarioPorID da nosssa classe que controla os usuarios do sistema
            livrosController.RemoverLivroPorId(livroID);

            //Informamos que o usuario foi desativado com sucesso
            Console.WriteLine("livro desativado com sucesso");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema");
            //Informamos que para dar continuidade ele deve informar um nome para olivro
            Console.WriteLine("Nome do livro para cadastro:");
            //obtemos esta info do usuario 
            var nomeDoLivro = Console.ReadLine();
            //com isso temos temos disponivel nele ferramentas que nos ajudam a realizar as tarefas 
            //como adicionar um item a nossa lista de livros 
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui "Atribuimos " o nome que devemos ao livro na propriedade Nome de nossolivro 
                //com o sinal de apenas um "=" temos atribuicao , passagem de valor 
                Nome = nomeDoLivro
            });

            //indico que finalizamos o processo de cadastro do livro , assim o usuario ja sabe 
            //que  o mesmo foi realizado e sem erros 
            Console.WriteLine("Livro cadastro com sucesso!");
            //Readkey apenas para que ele visualize esta informacão
            Console.ReadKey();
        }

        //-------------------------

        private static void AdicionarUsuario()
        {

            Console.WriteLine("Cadastrar Usuario dentro do sistema");
            Console.WriteLine(" -------^^-----------^^-----------^^-------");
            Console.WriteLine(" Login do usuario para cadastro:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine(" Senha do usuario para cadastro:");
            var SenhaDoUsuario = Console.ReadLine();


            usuarioController.AdicionarUsuario(new Usuario()
            {
                //Aqui "Atribuimos " o nome que devemos ao usuario na propriedade Nome de nossolivro 
                //com o sinal de apenas um "=" temos atribuicao , passagem de valor 
                Login = loginDoUsuario,
                Senha = SenhaDoUsuario
            });

            //indico que finalizamos o processo de cadastro do Usuario , assim o usuario ja sabe 
            //que  o mesmo foi realizado e sem erros 
            Console.WriteLine("Usuario cadastrado com sucesso!");
            //Readkey apenas para que ele visualize esta informacão
            Console.ReadKey();
        }
        private static void MostrarLivro()
        {
            livrosController.RetornaLivros().ForEach(i =>
            Console.WriteLine($"Id : {i.Id} Nome do livro:{i.Nome}"));

            Console.ReadKey();
        }
        private static void MostrarUsuario()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            usuarioController.RetornaListaDeUsuarios().ForEach(i =>
            Console.WriteLine($"Id :{i.Id} login usuario {i.Login}"));

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
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            //devemos apagar esta linha para que ele possa enregistrar cada usuario cadastrado
            // UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
        }
    }
}

//https://github.com/darkeght/Aula1Tuma2



/*using System;
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
            Console.WriteLine("Sistema de Locaçâo de livro 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha invalido");

            MostraMenuSistema();


           
            //aqui vamos pegar numero digitado 
            //executar proxima funcao 


            /*screvemos UsuarioController  no aparece o que fazemos nos fomos na referencia depois projeto e depois a gente clica no locacao boblioteca para iportar lo na referencia depois escrevemos em cima usuing locacao biblioteca.controller para pegar os dados de locacao bliblioteca

                 este permite que acesamos os dados que estao dentro do usuariocontroller - estamos intanca carega na memoria

                projeto nao executa clique no botom direto sobre a clase interface depois clique set as statup project assim ele vai poder ser compilado */


/*    }
    /// <summary>
    /// 
    /// mostrar no console o menu disponivel do sistema 
    /// </summary>
    private static void MostraMenuSistema()

    {


        var menuEscolhido = int.MinValue;


        while (menuEscolhido != 0)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Locaçâo de livro 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("1 - Listar usuarios");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Cadastrar Livro");
            Console.WriteLine("0 - Sair");



            menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
            //executar proxima funcao 
            switch (menuEscolhido)
            {
                case 2:
                    MostrarLivro();

                    break;

                default:
                    break;

            }
        }
    }



    private static void MostrarLivro()

    {
        Livro livro = new Livro()
        {
            Nome = "Meu livro - xxx"
        };
        Console.WriteLine();
    }



    /// <summary>
    /// Metodo que realiza os procedimentos completos de login dentro de sistema 
    /// como solicitacao de login e senha pelo console assim como a 
    /// respectivas validacoes que o mesmo precisa para entrar no sistema 
    /// </summary>
    /// 
    ///retorna verdadeiro quando o login e senha informado estiveram corretos 
    /// <returns></returns>
    private static bool RealizaLoginSistema()
    {
        Console.WriteLine("Informe seu login e senha para acessar:");

        Console.WriteLine("Login");
        var loginDoUsuario = Console.ReadLine();

        Console.WriteLine("Senha");
        var senhaDoUsuario = Console.ReadLine();

        UsuarioController usuarioController = new UsuarioController();

        // colocamos return ja que declaramos como bool o return ja retorna true or false
        //    return usuarioController.LoginSistema(new Usuario()


        Usuario usuario = new Usuario();

        usuario.Login = loginDoUsuario;
        usuario.Senha = senhaDoUsuario;

        return usuarioController.LoginSistema(usuario);
    }


}

}

*/
