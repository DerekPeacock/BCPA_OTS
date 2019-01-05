using System;
using System.ComponentModel.DataAnnotations;

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
    public class Agent : Person
    {
        public int SeatRange { get; set; }

        [DataType(DataType.Date), 
            DisplayFormat(DataFormatString ="{0:dd/mm/yyyy}", 
            ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date),
            DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        

    }
}
