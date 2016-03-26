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
        [Key]
        public int MembershipId { get; set; }
        [Display(Name = "Membership")]
        public string MembershipName { get; set; }
        [Display(Name = "Description")]
        public string MembershipDescription { get; set; }
        [Display(Name = "Price")]
        public string MembershipPrice { get; set; }
    }
}