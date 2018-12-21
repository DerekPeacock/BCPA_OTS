using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public class PaymentCard
    {
        [ForeignKey("Person")]
        public int PaymentCardID { get; set; }
        public int CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public string SecurityNumber { get; set; }

        private Person Person;

    }
}
