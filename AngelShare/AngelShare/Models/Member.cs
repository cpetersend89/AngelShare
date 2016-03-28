using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngelShare.Models
{
    public class Member : IdentityUser
    {
        public virtual MemberInfo MemberInfo { get; set; }

     
        public virtual WhiskeyBox WhiskeyBox { get; set; }
        public virtual Membership Membership { get; set; }

    }
}