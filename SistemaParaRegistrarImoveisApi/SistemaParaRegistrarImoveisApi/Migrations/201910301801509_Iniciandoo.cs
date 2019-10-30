namespace SistemaParaRegistrarImoveisApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iniciandoo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Cep = c.String(),
                        Uf = c.String(),
                        Municipio = c.String(),
                        Complemento = c.String(),
                        Numero = c.Int(nullable: false),
                        Proprietario = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Imovels");
        }
    }
}
