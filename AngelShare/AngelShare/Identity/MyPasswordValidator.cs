using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AngelShare.Models;
using Microsoft.AspNet.Identity;

namespace AngelShare.Identity
{
    public class MyPasswordValidator : PasswordValidator
    {
        public MyPasswordValidator()
        {
            this.RequireLowercase = true;
            this.RequireUppercase = true;
            this.RequireDigit = true;
            this.RequireNonLetterOrDigit = true;
            this.RequiredLength = 8;
        }

        public override Task<IdentityResult> ValidateAsync(string password)
        {
            return base.ValidateAsync(password); 
        }
    }
}