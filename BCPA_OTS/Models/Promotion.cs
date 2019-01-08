using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public class Promotion
    {
        public int PromotionID { get; set; }

        [DataType(DataType.Currency), DisplayFormat(DataFormatString ="{0:c}", ApplyFormatInEditMode = false)]
        [Display(Name ="Orchestra Seat")]
        public decimal OrchestraPrice { get; set; }

        [DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Display(Name = "Stalls Seat")]
        public decimal StallPrice { get; set; }

        [DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Display(Name = "Back Seat")]
        public decimal BackPrice { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Range(0,100, ErrorMessage ="Must be a % between 0 and 90")]
        public int AdultDiscount { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int StudentDiscount { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int ChildDiscount { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int SeniorDiscount { get; set; }

        public Promotion()
        {
            Name = "Standard Prices";

            OrchestraPrice = 20.00m;
            StallPrice = 30.00m;
            BackPrice = 15.00m;

            AdultDiscount = 0;
            StudentDiscount = 10;
            ChildDiscount = 40;
            SeniorDiscount = 10;
        }
        //private Event Event;

    }
}
