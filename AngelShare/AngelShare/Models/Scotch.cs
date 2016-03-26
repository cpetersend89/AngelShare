using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
    public class Scotch : Whiskey
    {
        public bool IsSingleMalt { get; set; }
        public bool IsHighland { get; set; }
        public bool IsLowland { get; set; }
        public bool IsIslay { get; set; }
        public bool IsSpeyside { get; set; }
        public bool IsPeated { get; set; }
    }
}