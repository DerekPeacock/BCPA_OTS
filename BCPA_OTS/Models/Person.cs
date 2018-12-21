using System;

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
        public int CustomerID { get; set; }
        
        /// <summary>
        /// Foreign Key
        /// 
        /// Is stored so it is known where the tickets are to be mailed and so 
        /// customers can later be targeted by promotions
        /// 
        /// DSS
        /// </summary>
        public int AddressID { get; set; }
        
        /// <summary>
        /// Foreign Key
        /// Used to uniquely identify the customer so they can login
        /// 
        /// DSS
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// This is the unique name the agent has to login to the system and access/sell tickets.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Used to identify the customer
        /// 
        /// DSS
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Used to identify the customer
        /// 
        /// DSS
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Used to contact the customer
        /// 
        /// DSS
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Used to contact and identify customer
        /// 
        /// DSS
        /// </summary>
        public string PhoneNumber { get; set; }

 
        public int PaymentCardID { get; set; }


        /// <summary>
        /// Used to register and store the customers information so the 
        /// customer can login using the created credentials if they 
        /// haven't already registered, as well as so the address can 
        /// be stored so tickets and promotions can be sent
        /// 
        /// DSS
        /// </summary>
        public void RegisterCustomer()
        {
            throw new System.Exception("Not implemented");
        }

        //public virtual Address Address;
        //public virtual Purchase[] Purchases;
        //public virtual Staff staff;
    }
}
