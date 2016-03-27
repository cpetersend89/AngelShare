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
        public int Id { get; set; }
        public List<Whiskey> Whiskeys { get; set; }
    }
}