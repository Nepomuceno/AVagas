namespace AVagas.Core.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiraConfiguracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vagas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 500),
                        Endereco = c.String(),
                        Coberto = c.Boolean(nullable: false),
                        Disponivel = c.Boolean(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Foto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vagas");
        }
    }
}
