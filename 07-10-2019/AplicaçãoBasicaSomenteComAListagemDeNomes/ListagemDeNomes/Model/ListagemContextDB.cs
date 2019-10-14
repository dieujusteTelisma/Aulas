using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeNomes.Model
{
   public  class ListagemContextDB : DbContext

    {
        public DbSet<Nomes>

            ListaDeNome
        { get; set; }
    }
}
