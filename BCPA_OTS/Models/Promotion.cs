using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public class Promotion
    {
        public int PromotionID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Range(1,100, ErrorMessage ="Must be a % between 1 and 90")]
        public int AdultDiscount { get; set; }

        [Range(1, 100, ErrorMessage = "Must be a % between 1 and 90")]
        public int StudentDiscount { get; set; }

        [Range(1, 100, ErrorMessage = "Must be a % between 1 and 90")]
        public int ChildDiscount { get; set; }

        [Range(1, 100, ErrorMessage = "Must be a % between 1 and 90")]
        public int SeniorDiscount { get; set; }

        //private Event Event;

    }
}
