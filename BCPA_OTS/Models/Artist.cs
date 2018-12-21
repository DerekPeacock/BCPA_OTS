using System;
namespace BCPA_OTS.Models
{
    public class Artist
    {

        // This is their theatrical unique name
        public string ArtistID { get; set; }

        // do not need this
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        //private Event[] Events;

    }
}
