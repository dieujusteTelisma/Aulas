
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model


{
    //aqui devemos da control ponto para instalar o package last version frame 
    public class LocacaoContext : DbContext
    {
        ///Propriedade que armazena o ID dos livros adicionado ao sistema
        public DbSet<Livro> Livros { get; set; }

     
    }
}