namespace CorreiosWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CorreiosContext : DbContext
    {
        // Your context has been configured to use a 'CorreiosContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CorreiosWebApi.Models.CorreiosContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CorreiosContext' 
        // connection string in the application configuration file.
        public CorreiosContext()
            : base("name=CorreiosContext")
        {
        }

      //  public System.Data.Entity.DbSet<CorreiosWebApi.Models.Endereco> Enderecoes { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Endereco> Enderecos { get; set; }
        

    }

   
}