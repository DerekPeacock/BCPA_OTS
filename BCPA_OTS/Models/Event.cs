using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// William Foster
    /// </summary>
    public class Event
    {
        public int EventID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The starting date and time of the event, displayed in
        /// a 24 hour clock format e.g. 24/09/2019 at 19:00.
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name="Date of Event")]
        [DisplayFormat(DataFormatString ="0:dd/MM/yyyy H:mm", ApplyFormatInEditMode = true)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        ///  A measure of the duration of the event, 
        ///  measured in hours and minutes.
        /// </summary>
        [Required, DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:H:mm}", ApplyFormatInEditMode = true)]
        public DateTime Duration { get; set; }

        /// <summary>
        /// The URL of the image being used in the event's 
        /// decrption, e.g. an image of a representative 
        /// or company attending the event.
        /// </summary>
        [Required, StringLength(100), DataType(DataType.ImageUrl), Display(Name="Image")]
        public string ImageURL { get; set; }

        /// <summary>
        /// The URL of a video being played on the event's
        /// details page. In the case of an event, it may 
        /// be an informative video of what the event will 
        /// be about and its schedule.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.Url), Display(Name = "Video")]
        public string VideoURL { get; set; }

        /// <summary>
        /// A short description of the event 
        /// and its contents.
        /// </summary>
        [Required, StringLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

    }
}
