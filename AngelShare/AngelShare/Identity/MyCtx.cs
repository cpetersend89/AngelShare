using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngelShare.Models
{
    public class MyCtx : IdentityDbContext<MyUser>
    {
        public MyCtx(string connectionString)
            : base(connectionString)
        {
            
        }
    }
}