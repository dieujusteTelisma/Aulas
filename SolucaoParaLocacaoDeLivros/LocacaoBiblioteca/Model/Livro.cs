using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Livro
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public bool Ativo { get; internal set; } = true;

    }

        
}
