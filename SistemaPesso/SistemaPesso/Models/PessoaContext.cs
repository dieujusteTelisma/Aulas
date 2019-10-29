namespace SistemaPesso.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    // lebra que este projeto é completo vai ete banco de dados 
    // este é para criar uma claase para conectar com banco de 
    // aqui criamos uma nova solucao web indo no Data depois escolhe o primeiro que tem a ver com web e depois escohe empty code first model  depois temos que rebuild o projecto
    // depois vamos criar ppegar nossa pessoa controller clicando sobre controller add + escolhe web api 2 controller actions using entity frame work 
    //depois escolhe a classe model que vi ser pessoa o context ja vai aparecer  depois add e vai criar todo
    public class PessoaContext : DbContext
    {
        // Your context has been configured to use a 'PessoaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SistemaPesso.Models.PessoaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PessoaContext' 
        // connection string in the application configuration file.
        public PessoaContext()
            : base("name=PessoaContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

}