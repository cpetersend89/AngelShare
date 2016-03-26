using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
    public class AngelShareContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Whiskey> Whiskeys { get; set; }
        public DbSet<WhiskeyBox> WhiskeyBoxes { get; set; }
        public DbSet<Survey> Surveys { get; set; }
    }
}