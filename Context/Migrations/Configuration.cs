﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Context.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Context.PersonContext";
        }

        protected override void Seed(Context.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
