using System;
namespace BCPA_OTS.Models
{
    /// <summary>
    /// The manager is in charge of overseeing the venue.
    /// 
    /// Author: Zeeshan
    /// </summary>

    public class Manager
    {
        public int ManagerID { get; set; }

        public int VenueID { get; set; }

        /// <summary>
        /// A process the manager can start to cancel a show
        /// </summary>
        public void CancelEvent()
        {
            throw new System.Exception("Not implemented");
        }
        public void RescheduleEvent()
        {
            throw new System.Exception("Not implemented");
        }
        public void AddEvent()
        {
            throw new System.Exception("Not implemented");
        }
        public void CreateSeatLimit()
        {
            throw new System.Exception("Not implemented");
        }
        /// <summary>
        /// Before an event is viewable on the website, the manager will apply a pricing structure for it. This will layout the prices for the different seat types.
        /// 
        /// Orchestra seats will be the most expensive seats, followed by stalls, and back seats which tend to be the most affordable seats.
        /// 
        /// WF
        /// </summary>
        public void ApplyPricingStructure()
        {
            throw new System.Exception("Not implemented");
        }

        private Venue venue;

    }
}
