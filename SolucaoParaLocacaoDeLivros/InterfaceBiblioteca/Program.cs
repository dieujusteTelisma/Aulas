
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
        static UsuarioController usuario = new UsuarioController();
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
                Console.WriteLine("4 - Fazer logof");
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
                        //MostrarLivro();
                        break;
                    case 4:
                        Console.Clear();
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");

                        break;
                    default:
                        break;
                }
            }
        }

        private static void MostrarLivro()
        {
            livros.Livros.ForEach(i =>
            Console.WriteLine($"Nome do livro:{i.Nome}"));

            Console.ReadKey();
        }
        private static void MostrarUsuario()
        {
            usuario.Usuario.ForEach(i =>
            Console.WriteLine($"o login do usuario é :{i.Login}"));

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
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

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
