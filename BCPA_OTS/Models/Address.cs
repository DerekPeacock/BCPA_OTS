using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public enum Counties
    {
        [Display(Name = "Buckinghamshire")]
        BUCKINGHAMSHIRE,
        [Display(Name = "Bedfordshire")]
        BEDFORDSHIRE,
        [Display(Name = "Hertfordshire")]
        HERTFORDSHIRE,
        [Display(Name = "London")]
        LONDON,
        [Display(Name = "Northamtonshire")]
        NORTHAMTONSHIRE,
        [Display(Name = "Oxfordshire")]
        OXFORDSHIRE
    }

    /// <summary>
    /// 
    /// Assumption: The delivery address of customers will be the same as their billing address.
    /// </summary>
    public class Address
    {
        [ForeignKey("Person")]
        public int AddressID { get; set; }

        public string House { get; set; }

        public string Street { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public Counties County { get; set; }

        public virtual Person Person { get; set; }

    }
}
