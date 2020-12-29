namespace VeterinaryStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doktorIzmjena : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Doktors", name: "Gradovi_Id", newName: "GradoviId");
            RenameColumn(table: "dbo.Doktors", name: "Zvanje_Id", newName: "ZvanjeId");
            RenameIndex(table: "dbo.Doktors", name: "IX_Gradovi_Id", newName: "IX_GradoviId");
            RenameIndex(table: "dbo.Doktors", name: "IX_Zvanje_Id", newName: "IX_ZvanjeId");
            AddColumn("dbo.Doktors", "KorisnickiNalogId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doktors", "KorisnickiNalogId");
            RenameIndex(table: "dbo.Doktors", name: "IX_ZvanjeId", newName: "IX_Zvanje_Id");
            RenameIndex(table: "dbo.Doktors", name: "IX_GradoviId", newName: "IX_Gradovi_Id");
            RenameColumn(table: "dbo.Doktors", name: "ZvanjeId", newName: "Zvanje_Id");
            RenameColumn(table: "dbo.Doktors", name: "GradoviId", newName: "Gradovi_Id");
        }
    }
}
