using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// William Foster
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// A unique identification number, 
        /// by which to identify the ticket with.
        /// </summary>
        public int TicketID { get; set; }

        /// <summary>
        /// A true or false statement to identify
        /// whether the event is classed as an event.
        /// </summary>
        public bool Event { get; set; }

        /// <summary>
        /// A second true or false statement 
        /// whether the event is classed as a show.
        /// </summary>
        public bool Show { get; set; }

        /// <summary>
        /// The cost of a single ticket.
        /// </summary>
        [Required, DisplayFormat(DataFormatString ="{0:c}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        
        /// <summary>
        /// Refers to the act of the customer 
        /// purchasing a ticket.
        /// </summary>
        public void Buy()
        {
            throw new System.Exception("Not implemented");
        }

        // Navigation Properties

        public string SeatID { get; set; }

        public virtual Seat seat { get; set; }

        //private Agent agent;

        //private Event event;

        //private Purchase  Purchase;

    }
}
