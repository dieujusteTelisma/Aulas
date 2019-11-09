using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DensidadeObjeto.Model
{
    public class DensidadeWepApiContext : DbContext
    {
        public DensidadeWepApiContext(DbContextOptions<DensidadeWepApiContext> options) : base(options)
        {

        }

        public DbSet<Objeto> Objetos { get; set; }
    }
}
