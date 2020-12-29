namespace VeterinaryStation.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<VeterinaryStation.DAL.VeterinaryStationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VeterinaryStation.DAL.VeterinaryStationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.KorisnickiNalozi.AddOrUpdate(

             new Models.KorisnickiNalog
             {
                 Username = "admin",
                 Password = "admin",


                 IsDeleted = false
             }
              );
            context.Gradovii.AddOrUpdate(

               new Models.Gradovi
               {
                   Naziv = "Mostar",
                   IsDeleted = false
               }
                );
            context.StrucneSpremee.AddOrUpdate(

               new Models.StrucneSpreme
               {
                   Naziv = "Strucna Sprema 1 ",
                   IsDeleted = false
               }
                );
        }
    }
}
