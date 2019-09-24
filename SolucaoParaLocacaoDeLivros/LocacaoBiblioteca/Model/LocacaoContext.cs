using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdContadorLivros { get; set; } = 1;
        public LocacaoContext()
        {

            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Primeiro Livro"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Segundo Livro"
            });
        }
        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }

    }
}
