using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{

    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController
    {

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// para realizar o login parao use 
        /// login : Admin
        /// senha : Admin
        /// </summary>
        /// <param name="usuarios"></param>  passamos um bojeto de nome usuario como parametrologin do usuario dentro do sistema

        /// <returns></returns> retorna verdaddeiro quando existir o usuario com este login e senha
        //   public bool LoginSistema(string login , string senha)

        public bool LoginSistema(Usuario usuarios)



        {
            //   if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
            //     return true;
            // else
            //    return false;

            return Usuario.Exists(x =>
            x.Login == usuarios.Login
            && x.Senha == usuarios.Senha);

        }


        public UsuarioController()
        {

            Usuario = new List<Usuario>();

            Usuario.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"
            });

            Usuario.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"
            });


        }

        // public List<Livro> Livros { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
