using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
  
    public class Survey
    {    
    
        public string CoffeeQuestionResponse { get; set; }
        public string NoseQuestionResponse { get; set; }
        public string WhiskeyDrinkResponse { get; set; }
        public string TypeOfWhiskyResponse { get; set; }
        public string AbvPreferenceResponse { get; set; }
        public string NewSpiritsResponse { get; set; }
    }
}