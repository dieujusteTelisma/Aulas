namespace SistemaParaRegistrarImoveisApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TESTE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proprietarios", "DataNascimento", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proprietarios", "DataNascimento", c => c.Int(nullable: false));
        }
    }
}
