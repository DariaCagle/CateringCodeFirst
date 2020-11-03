using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
