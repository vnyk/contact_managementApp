namespace crud1.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class ApplicaionDbConfiguration : DbMigrationsConfiguration<crud1.Models.crud1Context>
    {
        public ApplicaionDbConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(crud1.Models.crud1Context context)
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
