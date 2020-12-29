namespace VeterinaryStation.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class adminizmjena2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Administrators", name: "Gradovi_Id", newName: "GradoviId");
            RenameColumn(table: "dbo.Administrators", name: "StrucneSpreme_Id", newName: "StrucneSpremeId");
            RenameIndex(table: "dbo.Administrators", name: "IX_StrucneSpreme_Id", newName: "IX_StrucneSpremeId");
            RenameIndex(table: "dbo.Administrators", name: "IX_Gradovi_Id", newName: "IX_GradoviId");
        }

        public override void Down()
        {
            RenameIndex(table: "dbo.Administrators", name: "IX_GradoviId", newName: "IX_Gradovi_Id");
            RenameIndex(table: "dbo.Administrators", name: "IX_StrucneSpremeId", newName: "IX_StrucneSpreme_Id");
            RenameColumn(table: "dbo.Administrators", name: "StrucneSpremeId", newName: "StrucneSpreme_Id");
            RenameColumn(table: "dbo.Administrators", name: "GradoviId", newName: "Gradovi_Id");
        }
    }
}
