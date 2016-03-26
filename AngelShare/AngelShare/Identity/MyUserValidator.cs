using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AngelShare.Models;
using Microsoft.AspNet.Identity;

namespace AngelShare.Identity
{
    public class MyUserValidator : UserValidator<MyUser>
    {
        public MyUserValidator(UserManager<MyUser> mgr)
            : base(mgr)
        {
            this.RequireUniqueEmail = false;
            this.AllowOnlyAlphanumericUserNames = true;
        }

        public override async Task<IdentityResult> ValidateAsync(MyUser user)
        {
            var result = await base.ValidateAsync(user);

            var errors = new List<string>();
            if (!result.Succeeded)
            {
                errors.AddRange(result.Errors);
            }
            if (user.Age <= 0)
            {
                errors.Add("Invalid age");
            }
            if (errors.Any())
            {
                return new IdentityResult(errors); 
            }
            return IdentityResult.Success;
        }
    }
}