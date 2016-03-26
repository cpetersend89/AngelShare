using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
    [Table("WhiskeyBox")]
    public class WhiskeyBox
    {
        [Key]
        public int BoxId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public virtual Whiskey Whiskey { get; set; }
    }
}