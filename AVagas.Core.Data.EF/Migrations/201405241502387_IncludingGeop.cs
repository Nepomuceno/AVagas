namespace AVagas.Core.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    
    public partial class IncludingGeop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vagas", "Localizacao", c => c.Geography());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vagas", "Localizacao");
        }
    }
}
