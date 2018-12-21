using System;
namespace BCPA_OTS.Models
{
    /// <summary>
    /// The agent is responsible for selling tickets for specific seats.
    /// 
    /// Author: Zeeshan
    /// 
    /// Assumption: An agent is an individual working for an entertainment 
    /// company, selling tickets. They will work in a location different 
    /// to the one that the venue is located in and sell a set number of 
    /// tickets to customers who come to their business.
    /// </summary>
    public class Agent
    {
        public int AgentID { get; set; }

        public int SeatRange { get; set; }

        public DateTime DateRange { get; set; }

        public Ticket[] tickets;

    }
}
