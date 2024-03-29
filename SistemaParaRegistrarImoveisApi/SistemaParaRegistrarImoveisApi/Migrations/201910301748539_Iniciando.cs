﻿namespace SistemaParaRegistrarImoveisApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iniciando : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proprietarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietarios");
        }
    }
}
