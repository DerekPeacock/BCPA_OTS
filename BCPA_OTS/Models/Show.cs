using System;
using System.Collections.Generic;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Considered to be time constrained and often a stage performance.
    /// 
    /// 
    /// Author: Zeeshan
    /// </summary>
    public class Show
    {
        public int ShowID { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public string VideoURL { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

    }
}
