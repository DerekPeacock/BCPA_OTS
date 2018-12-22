using System;
using System.Collections.Generic;

namespace BCPA_OTS.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        public DateTime Date { get; set; }

        public bool EmailSent { get; set; }

        public DateTime DateTicketSent { get; set; }

        public int PersonID { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual Person Person { get; set; }

    }
}
