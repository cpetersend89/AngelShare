﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace AngelShare.Models
{

    public class WhiskeyBox 
    {
        public int Id { get; set; }
        public int WhiskeyID { get; set; }
        public virtual Whiskey Whiskey { get; set; }

        public int MembershipID { get; set; }
        public virtual Membership Membership { get; set; }
       
    }
}