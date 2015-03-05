using comp4976assn2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace comp4976assn2.Migrations
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

            // User Manager
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            // Create Users
            var adam = new ApplicationUser {UserName = "adam@gs.ca"};
            var wendy = new ApplicationUser {UserName = "wendy@gs.ca"};
            var rob = new ApplicationUser { UserName = "rob@gs.ca"};

            IdentityResult adamCreate = null, wendyCreate = null, robCreate = null;
            if (!context.Users.Any(u => u.UserName == "adam@gs.ca"))
            {
                adamCreate = userManager.Create(adam, "P@$$w0rd");
            }
            if (!context.Users.Any(u => u.UserName == "adam@gs.ca"))
            {
                wendyCreate = userManager.Create(wendy, "P@$$w0rd");
            }
            if (!context.Users.Any(u => u.UserName == "adam@gs.ca"))
            {
                robCreate = userManager.Create(rob, "P@$$w0rd");
            }

            // Add Users to Roles
            if (adamCreate != null && adamCreate.Succeeded)
            {
                userManager.AddToRole(adam.Id, admin);
            }
            if (wendyCreate != null && wendyCreate.Succeeded)
            {
                userManager.AddToRole(wendy.Id, worker);
            }
            if (robCreate != null && robCreate.Succeeded)
            {
                userManager.AddToRole(rob.Id, report);
            }

            base.Seed(context);
        }
    }
}
