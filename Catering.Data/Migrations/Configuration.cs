using System.Data.Entity.Migrations;

namespace Catering.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CateringContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CateringContext context)
        {

        }
    }
}
