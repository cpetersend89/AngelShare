using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelShare.Models
{
    [Table("Surveys")]
    public class Survey
    {
        [Key]
        public int SurveyId { get; set; }
        public string CoffeeQuestionResponse { get; set; }
        public string NoseQuestionResponse { get; set; }
        public string WhiskeyDrinkResponse { get; set; }
        public string TypeOfWhiskyResponse { get; set; }
        public string AbvPreferenceResponse { get; set; }
        public string NewSpiritsResponse { get; set; }
    }
}