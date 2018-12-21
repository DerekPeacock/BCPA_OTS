using System;
namespace BCPA_OTS.Models
{
    public class PricingStructure
    {
        public int PricingStructureID { get; set; }

        public decimal AdultTicketPrice { get; set; }

        public decimal StudentTicketPrice { get; set; }

        public decimal ChildTicketPrice { get; set; }

        public decimal SeniorTicketPrice { get; set; }

        //private Event Event;

    }
}
