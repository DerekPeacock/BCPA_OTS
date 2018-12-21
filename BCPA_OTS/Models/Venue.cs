using System;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// This is where the events are hosted.
    /// 
    /// Author: Zeeshan
    /// </summary>
    public class Venue
    {
        public string VenueID { get; set; }

        public string Location { get; set; }

        public int OpeningTime { get; set; }

        public int ClosingTime { get; set; }

        public string Name { get; set; }

        //private Ticket ticket;

        //private Event event;

        //private Seat seat;

        //private Manager manager;

    }
}
