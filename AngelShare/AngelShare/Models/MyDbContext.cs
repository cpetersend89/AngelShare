using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
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
        public DbSet<MemberInfo> MyUserInfo { get; set; }
        public static MyDbContext Create()
        {
            return new MyDbContext();
        }
    }
}