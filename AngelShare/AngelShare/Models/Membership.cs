using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
   
    public class Membership
    {
        public int Id { get; set; }
        [Display(Name = "Membership")]
        public string MembershipName { get; set; }
        [Display(Name = "Description")]
        public string MembershipDescription { get; set; }
        [Display(Name = "Price")]
        public decimal MembershipPrice { get; set; }
    }
}