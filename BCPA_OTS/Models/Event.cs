using System;
namespace BCPA_OTS.Models
{
    /// <summary>
    /// Considered to be long lasting and open in terms of timing, 
    /// an event can last several hours at the venue.
    /// 
    /// A show is considered to be time constrained and often a stage performance.
    /// 
    /// Author: Zeeshan
    /// </summary>
    public class Event
    {
        public int EventID { get; set; }

        public string Name { get; set; }

        // 24 hour clock?
        public DateTime StartDateTime { get; set; }

        // Measure in hours and minutes
        public DateTime Duration { get; set; }

        public string Image { get; set; }

        public string Video { get; set; }

        public string Description { get; set; }

        public bool IsShow { get; set; }

        private Ticket[] tickets;
        //private PricingStructure PricingStructure;
	    private Artist[] Artists;

    }
}
