using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
  
    public class Whiskey
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Proof { get; set; }
        public int Age { get; set; }
        public decimal Cost { get; set; }

        public virtual WhiskeyBox WhiskeyBox { get; set; }
    }
}
