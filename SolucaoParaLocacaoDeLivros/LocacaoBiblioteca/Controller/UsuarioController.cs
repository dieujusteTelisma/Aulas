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

        //criando privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int IdContador = 1;
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
                //adiciono o ID contador incrementando o mesmo com ele + 1 "++"
                Id = IdContador++,
                Login = "admin",
                Senha = "admin"
            });


        }

        // public List<Livro> Livros { get; set; }
        private List<Usuario> Usuario { get; set; }

        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="parametroUsuario">Novo usuario qu sera adicionado a lista </param>
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            parametroUsuario.Id = IdContador++;
            //Adicionar o meu usuario a minha lista de usuario (Usuario é minha lista)
            Usuario.Add(parametroUsuario);
        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>lista contendo os usuarios </returns>
        /// este metodo foi criado so porque a gente declara  private List<Usuario> Usuario { get; set; } como privado para nao poder criar outro usuario dentro do parentses que esta dentro do metodo adicionarusuario
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente a lista de usuario ativos
            return Usuario.Where(x => x.Ativo).ToList<Usuario>();
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nosa lista
        /// </summary>
        /// <param name="identificadoID"> Parametro que identifica o usuario que sera desativado</param>
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //AQUI USAMOS O METODO firstOrDefault para localizar nosso usuario dentro da lista
            //Com isso conseguimos acessar as propriedades dele e desativar o registro
            Usuario.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
        
    }
}
