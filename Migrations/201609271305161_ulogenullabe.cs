namespace VeterinaryStation.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ulogenullabe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KorisnickiNalogs", "doc", c => c.Boolean(nullable: false));
            AlterColumn("dbo.KorisnickiNalogs", "teh_osob", c => c.Boolean(nullable: false));
            AlterColumn("dbo.KorisnickiNalogs", "admin", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.KorisnickiNalogs", "admin", c => c.Boolean());
            AlterColumn("dbo.KorisnickiNalogs", "teh_osob", c => c.Boolean());
            AlterColumn("dbo.KorisnickiNalogs", "doc", c => c.Boolean());
        }
    }
}
