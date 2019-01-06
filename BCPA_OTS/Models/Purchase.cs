using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        [Required, DataType(DataType.DateTime), Display(Name = "Date of Event")]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
        public DateTime DatePaid { get; set; }

        [Required, DataType(DataType.DateTime), Display(Name = "Date of Event")]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateTicketsSent { get; set; }

        public bool EmailSent { get; set; }

        public int MinTicketsForDiscount { get; set; }

        public decimal MinCostForDiscount { get; set; }

        [Range(1, 100, ErrorMessage = "Must be a % between 1 and 90")]
        public int VolumeDiscount { get; set; }
        
        
        // Navigation Properties

        public int PersonID { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public decimal CalculateTotalCost()
        {
            decimal cost = 0;
            foreach (Ticket ticket in Tickets)
                cost = cost + ticket.Price;

            return cost - cost * VolumeDiscount / 100;
        }


    }
}
