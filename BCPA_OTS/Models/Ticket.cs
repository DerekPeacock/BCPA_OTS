using System;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// This is a ticket for a show or event on a particular date and 
    /// time and a particular seat.
    /// 
    /// Author: William
    /// </summary>
    public class Ticket
    {
        public int TicketID { get; set; }

        public DateTime PurchaseDate { get; set; }

        public bool Event { get; set; }

        public bool Show { get; set; }

        public decimal Price { get; set; }

        public string SeatID { get; set; }

        /// <summary>
        /// When the customer buys the ticket
        /// 
        /// DSS
        /// </summary>
        public void Buy()
        {
            throw new System.Exception("Not implemented");
        }

        public virtual Seat seat { get; set; }

        //private Agent agent;

        //private Event event;

        //private Purchase  Purchase;

    }
}
