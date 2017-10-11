namespace Oct9_2017SuggestionBoxMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Oct9_2017SuggestionBoxMVC.Models.Oct9_2017SuggestionBoxMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Oct9_2017SuggestionBoxMVC.Models.Oct9_2017SuggestionBoxMVCContext";
        }

        protected override void Seed(Oct9_2017SuggestionBoxMVC.Models.Oct9_2017SuggestionBoxMVCContext context)
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
        }
    }
}
