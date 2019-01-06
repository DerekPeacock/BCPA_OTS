using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// William Foster
    /// </summary>
    public class Show
    {
        public int ShowID { get; set; }

        /// <summary>
        /// The starting date and time of the event, displayed in
        /// a 24 hour clock format e.g. 24/09/2019 at 19:00.
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "Date of Show")]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy H:mm", ApplyFormatInEditMode = true)]
        public DateTime PerformanceDate { get; set; }

        // Navigation Properties

        public Promotion Promotion { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

    }
}
