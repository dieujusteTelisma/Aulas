using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Migrations.Model
{
    public class MigrationContext : DbContext  // install last version dando control ponto quando aparece oerro 
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}