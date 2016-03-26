using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngelShare.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngelShare.Identity
{
    public class MyUserManager : UserManager<MyUser>
    {
        public MyUserManager()
            : base(new UserStore<MyUser>(new MyCtx("ndc-london")))
        {
            this.UserValidator = new MyUserValidator(this);
            this.PasswordValidator = new MyPasswordValidator();
        }
    }
}