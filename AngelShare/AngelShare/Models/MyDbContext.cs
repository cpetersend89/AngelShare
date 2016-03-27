using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngelShare.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<WhiskeyBox> WhiskeyBoxes { get; set; }
        public DbSet<Whiskey> Whiskeys { get; set; }     
        public DbSet<Membership> Memberships { get; set; }
        public static MyDbContext Create()
        {
            return new MyDbContext();
        }
    }
}