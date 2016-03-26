using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
   
    public class WhiskeyBox
    {
        public WhiskeyBox()
        {
            Whiskeys = new List<Whiskey>();
        }   
        public int BoxId { get; set; }
        public virtual List<Whiskey> Whiskeys { get; set; }
    }
}