namespace SistemaParaRegistrarImoveisApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaParaRegistrarImoveisApi.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SistemaParaRegistrarImoveisApi.Models.MigrationContext";
        }

                   /*Cara que vamos escolher pra voltar a versão*/   /*(Detalhamento do processamento) */
        //update-database -TargetMigration:"201910301748539_Iniciando" -verbose 
        // todas vezes que mudamos alg especalmente os tipos das variaveis a gente da targer depoiss add imigration 
        protected override void Seed(SistemaParaRegistrarImoveisApi.Models.MigrationContext context)
        {
            context.Proprietarios.AddOrUpdate(new Models.Proprietario()
            {
                Nome = "Webster",
                DataNascimento = "28/09/1989",
                Email = "admin@admin.com.br"
            });

            context.Imoveis.AddOrUpdate(new Models.Imovel()
            {
                Logradouro = "we the best",
                Bairro = "Blumenau",
                Cep = "89023456",
                Uf = "SC",
                Municipio = "SC",
                Complemento = "Perto do sv"
            });

            context.SaveChanges();

        }

    }
}
