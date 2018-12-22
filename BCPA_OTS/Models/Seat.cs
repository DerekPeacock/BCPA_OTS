using System;
namespace BCPA_OTS.Models
{
    /// <summary>
    /// Where the customer would view/participate in the show/event.
    /// 
    /// Author: Zeeshan
    /// </summary>
    public class Seat
    {
        public string SeatID { get; set; }

        public string Type { get; set; }

        public bool AisleSeat { get; set; }

        //private Venue venue;

        //private Ticket[] tickets;

    }
}
