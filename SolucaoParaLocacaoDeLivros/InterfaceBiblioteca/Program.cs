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
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Locaçâo de livro 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha invalido");

            MostraMenuSistema();

            Console.ReadKey();

            //aqui vamos pegar numero digitado 
            //executar proxima funcao 


         /*screvemos UsuarioController  no aparece o que fazemos nos fomos na referencia depois projeto e depois a gente clica no locacao boblioteca para iportar lo na referencia depois escrevemos em cima usuing locacao biblioteca.controller para pegar os dados de locacao bliblioteca

              este permite que acesamos os dados que estao dentro do usuariocontroller - estamos intanca carega na memoria

             projeto nao executa clique no botom direto sobre a clase interface depois clique set as statup project assim ele vai poder ser compilado */
        }
        /// <summary>
        /// 
        /// mostrar no console o menu disponivel do sistema 
        /// </summary>
        private static void MostraMenuSistema()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Locaçâo de livro 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("1 - Listar usuarios");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("0 - Sair");

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
