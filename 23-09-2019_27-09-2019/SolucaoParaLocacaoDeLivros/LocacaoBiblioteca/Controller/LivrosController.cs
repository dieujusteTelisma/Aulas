using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{

    public class LivrosController
  

    {
        private int IdContador = 1;
        public LivrosController()
        {

            Livros = new List<Livro>();

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Primeiro Livro"
            });

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Segundo Livro"
            });
        }

        private List<Livro> Livros { get; set; }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista ja " instancia" criada endro do
        /// construtor
        /// </summary>
        /// <param name="parametroLivro"></param> Imformacoes do livro que vamod adicionar
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = IdContador++;
            Livros.Add(parametroLivro);
        }

        /// <summary>
        /// Metodo que retorna a lista de livro 
        /// </summary>
        /// <returns></returns>
        public List<Livro> RetornaLivros()
        {
            return Livros.Where(x => x.Ativo).ToList<Livro>();
        }

     
      
        public void RemoverLivroPorId(int identificadoID)
        {
            //AQUI USAMOS O METODO firstOrDefault para localizar nosso usuario dentro da lista
            //Com isso conseguimos acessar as propriedades dele e desativar o registro
           Livros.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;

        }

    }
}
