namespace AspNetBoilerplateSample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetBoilerplateSample.EntityFramework.AspNetBoilerplateSampleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AspNetBoilerplateSample";
        }

        protected override void Seed(AspNetBoilerplateSample.EntityFramework.AspNetBoilerplateSampleDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
