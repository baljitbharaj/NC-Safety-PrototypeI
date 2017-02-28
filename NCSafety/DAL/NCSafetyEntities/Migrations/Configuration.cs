namespace NCSafety.DAL.NCSafetyEntities.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NCSafety.DAL.NCSafetyEntities.NCSafetyCFEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DAL\NCSafetyEntities\Migrations";
        }

        protected override void Seed(NCSafety.DAL.NCSafetyEntities.NCSafetyCFEntities context)
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

            var schools = new List<School>
            {
                new School { schName = "Media" },
                new School {schName = "Trades" },
                new School {schName = "Technology" }
            };

            schools.ForEach(s => context.Schools.AddOrUpdate(n => n.schName, s));
            context.SaveChanges();

            var labs = new List<Lab>
            {
                new Lab { labBuilding = "TC", labNumber = "02" },
                new Lab { labBuilding = "L", labNumber = "117" },
                new Lab {labBuilding = "V", labNumber = "115"}
            };

            labs.ForEach(l => context.Labs.AddOrUpdate(b => b.labBuilding, l));
            context.SaveChanges();
        }
    }
    
}
