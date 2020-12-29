namespace VeterinaryStation.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class tehnicarIzmjena : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tehnicko_osoblje", name: "Gradovi_Id", newName: "GradoviId");
            RenameColumn(table: "dbo.Tehnicko_osoblje", name: "Odjeli_Id", newName: "OdjeliId");
            RenameIndex(table: "dbo.Tehnicko_osoblje", name: "IX_Gradovi_Id", newName: "IX_GradoviId");
            RenameIndex(table: "dbo.Tehnicko_osoblje", name: "IX_Odjeli_Id", newName: "IX_OdjeliId");
            AddColumn("dbo.Tehnicko_osoblje", "KorisnickiNalogId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Tehnicko_osoblje", "KorisnickiNalogId");
            RenameIndex(table: "dbo.Tehnicko_osoblje", name: "IX_OdjeliId", newName: "IX_Odjeli_Id");
            RenameIndex(table: "dbo.Tehnicko_osoblje", name: "IX_GradoviId", newName: "IX_Gradovi_Id");
            RenameColumn(table: "dbo.Tehnicko_osoblje", name: "OdjeliId", newName: "Odjeli_Id");
            RenameColumn(table: "dbo.Tehnicko_osoblje", name: "GradoviId", newName: "Gradovi_Id");
        }
    }
}
