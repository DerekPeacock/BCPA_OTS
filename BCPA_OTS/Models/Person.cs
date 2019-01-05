using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// The person who wishes to view the event at the venue.
    /// 
    /// Author: Zeeshan
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Primary Key
        /// 
        /// Used to identify unique customers
        /// 
        /// DSS
        /// </summary>
        [Key]
        public int PersonID { get; set; }
        
        /// <summary>
        /// Foreign Key
        /// 
        /// Is stored so it is known where the tickets are to be mailed and so 
        /// customers can later be targeted by promotions
        /// 
        /// DSS
        /// </summary>
        //public int AddressID { get; set; }
        
        /// <summary>
        /// Foreign Key
        /// Used to uniquely identify the customer so they can login
        /// 
        /// DSS
        /// </summary>
        //public string UserID { get; set; }

        /// <summary>
        /// This is the unique name the customer has to login to the system and access/sell tickets.
        /// </summary>
        //public string Username { get; set; }

        /// <summary>
        /// Used to identify the customer
        /// 
        /// DSS
        /// </summary>
        [StringLength(20), Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Used to identify the customer
        /// 
        /// DSS
        /// </summary>
        [StringLength(20), Required]
        public string LastName { get; set; }

        /// <summary>
        /// Used to contact the customer
        /// 
        /// DSS
        /// </summary>
        [StringLength(100), Required]
        public string Email { get; set; }

        /// <summary>
        /// Used to contact and identify customer
        /// 
        /// DSS
        /// </summary>
        [StringLength(20), Required]
        public string PhoneNumber { get; set; }

 
        //public int PaymentCardID { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        // Navigation Properties

        public virtual Address Address { get; set; }

        public virtual PaymentCard PaymentCard { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
