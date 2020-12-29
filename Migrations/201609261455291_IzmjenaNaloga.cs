namespace VeterinaryStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IzmjenaNaloga : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.KorisnickiNalogs", "IsAktivan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KorisnickiNalogs", "IsAktivan", c => c.Boolean());
        }
    }
}
