namespace AVagas.Core.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoberetoOpcional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vagas", "Coberto", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vagas", "Coberto", c => c.Boolean(nullable: false));
        }
    }
}
