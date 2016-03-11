namespace Context.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.ApplicationContext context)
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
           /// SetupEvictionRoles(context);
        }

        void SetupEvictionRoles(ApplicationContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var role = new IdentityRole
            {
                Name = "Admin"
            };

            if (!context.Roles.Any(a => a.Name == "Admin"))roleManager.Create(role);
            if (!context.Roles.Any(a => a.Name == "Client")) roleManager.Create(new IdentityRole() { Name="Client"});
            if (!context.Roles.Any(a => a.Name == "Vendor")) roleManager.Create(new IdentityRole() { Name = "Vendor" });
            if (!context.Roles.Any(a => a.Name == "Licensee")) roleManager.Create(new IdentityRole() { Name = "Licensee" });
            if (!context.Roles.Any(a=>a.Name=="Licensee_Admin"))roleManager.Create(new IdentityRole(){Name="Licensee_Admin"});
            if (!context.Roles.Any(a => a.Name == "Licensee_Processor")) roleManager.Create(new IdentityRole() { Name = "Licensee_Processor" });
            if (!context.Roles.Any(a => a.Name == "Client_Admin")) roleManager.Create(new IdentityRole() { Name = "Client_Admin" });
            if (!context.Roles.Any(a => a.Name == "Client_Processor")) roleManager.Create(new IdentityRole() { Name = "Client_Processor" });

            if (!context.Roles.Any(a => a.Name == "Nwe")) roleManager.Create(new IdentityRole() { Name = "Nwe" });
            if (!context.Roles.Any(a => a.Name == "Nwe_Admin")) roleManager.Create(new IdentityRole() { Name = "Nwe_Admin" });
            if (!context.Roles.Any(a => a.Name == "Nwe_Processor")) roleManager.Create(new IdentityRole() { Name = "Nwe_Processor" });



            var userStore = new UserStore<ApplicationUser>(context);
            var manager = new ApplicationUserManager(userStore);


            if (!context.Users.Any(u => u.Email == "Admin@nwe.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "Admin@nwe.com",
                    UserName = "Admin@nwe.com",

                };
                var result = manager.Create(user, "Admin1");

                if (result.Succeeded) manager.AddToRole(user.Id, "Admin");

            }

           

            if(!context.Users.Any(u=> u.Email== "Admin@nationwideeviction.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "Admin@nationwideeviction.com",
                    UserName = "Admin@nationwideeviction.com",

                };
                var result = manager.Create(user, "hT2012**");

                if (result.Succeeded) manager.AddToRole(user.Id, "Admin");
            }


            if (!context.Users.Any(u => u.Email == "licensee@nwe.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "licensee@nwe.com",
                    UserName = "licensee@nwe.com",

                };
                var result = manager.Create(user, "Licensee1");

                if (result.Succeeded) manager.AddToRole(user.Id, "Licensee");
                
            }

            //else
            //{
            //    var lic = manager.FindByEmail("licensee@nwe.com");
            //    var token = manager.GeneratePasswordResetToken(lic.Id);
            //    manager.ResetPassword(lic.Id, token, "Licensee1");
            //}


            if (!context.Users.Any(u => u.Email == "Client@nwe.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "Client@nwe.com",
                    UserName = "Client@nwe.com",

                };
                var result = manager.Create(user, "Client1");

                if (result.Succeeded) manager.AddToRole(user.Id, "Client");

            }
            if (!context.Users.Any(u => u.Email == "ClientCaseStatus@nwe.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "ClientCaseStatus@nwe.com",
                    UserName = "ClientCaseStatus@nwe.com",

                };
                var result = manager.Create(user, "ClienCS");

                if (result.Succeeded) manager.AddToRole(user.Id, "Client");

            }



            // Udpate Forms By PrecinctId 
            //MigrateFoms(context);



        }
     

      

    }
}
