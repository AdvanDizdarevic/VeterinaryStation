namespace VeterinaryStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class izmjenaNalogaAktivan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KorisnickiNalogs", "Aktivan", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KorisnickiNalogs", "Aktivan");
        }
    }
}
