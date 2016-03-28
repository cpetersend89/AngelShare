using AngelShare.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AngelShare.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AngelShare.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AngelShare.Models.ApplicationDbContext context)
        {
            //var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //string[] roleNames = { "Admin", "Member" };
            //IdentityResult roleResult;
            //foreach (var roleName in roleNames)
            //{
            //    if (!RoleManager.RoleExists(roleName))
            //    {
            //        roleResult = RoleManager.Create(new IdentityRole(roleName));
            //    }
            //}
            //var UserManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //UserManger.AddToRole("761f978f-508e-4553-836e-784d52abb8e7", "Admin");
            //var UserManger1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //UserManger.AddToRole("38f32110-d711-4bbf-8ede-0574b7746afe", "Admin");
        }
    }
}

