using comp4976assn2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace comp4976assn2.Migrations.IdentityMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<comp4976assn2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
        }

        protected override void Seed(comp4976assn2.Models.ApplicationDbContext context)
        {
            // Role Manager
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            // Create Roles
            const string admin = "Administrator";
            const string worker = "Worker";
            const string report = "Report";

            if (!roleManager.RoleExists(admin))
            {
                roleManager.Create(new IdentityRole(admin));
            }
            if (!roleManager.RoleExists(worker))
            {
                roleManager.Create(new IdentityRole(worker));
            }
            if (!roleManager.RoleExists(report))
            {
                roleManager.Create(new IdentityRole(report));
            }

            // Create Users
            var passwordHash = new PasswordHasher();
            var password = passwordHash.HashPassword("P@$$w0rd");

            var adam = new ApplicationUser { UserName = "adam", Email = "adam@gs.ca", PasswordHash = password };
            var wendy = new ApplicationUser { UserName = "wendy", Email = "wendy@gs.ca", PasswordHash = password };
            var rob = new ApplicationUser { UserName = "rob", Email = "rob@gs.ca", PasswordHash = password };

            context.Users.AddOrUpdate(u => u.UserName, adam);
            context.Users.AddOrUpdate(u => u.UserName, wendy);
            context.Users.AddOrUpdate(u => u.UserName, rob);

            // User Manager
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            // Add Users to Roles                  
            userManager.AddToRole(adam.Id, admin);
            userManager.AddToRole(wendy.Id, worker);
            userManager.AddToRole(rob.Id, report);

            base.Seed(context);
        }
    }
}
