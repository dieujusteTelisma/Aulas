using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class CelularesContextDB 
        : // definimos que vamos herdar 
        DbContext// aqui definimos que vamos herdar 
        //todas a caixa de ferramentas do entityframeworl 
    {
      public DbSet <Usuario> Usuarios { get; set; }

       public DbSet<Celular> Celulares { get; set; }
    }
}
