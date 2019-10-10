using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsercaoDeinformacoesDeUma.Model
{
   public  class FloreContextDB : DbContext

    {
        public DbSet<Flore> ListaDeFlores { get; set; }

        
    }
}
