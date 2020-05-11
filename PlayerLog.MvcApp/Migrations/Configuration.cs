namespace PlayerLog.MvcApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //sealed class: Bu classtan başka herhangi bir class türetilemez,base olarak kullanılamaz.
    internal sealed class Configuration : DbMigrationsConfiguration<PlayerLog.MvcApp.DAL.TakimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PlayerLog.MvcApp.DAL.TakimContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
