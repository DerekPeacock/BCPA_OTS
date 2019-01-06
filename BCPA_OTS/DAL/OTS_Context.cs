using System;
using System.Collections.Generic;
using System.Data.Entity;
using BCPA_OTS.Models;
using System.Linq;
using System.Web;

namespace BCPA_OTS.DAL
{
    public class OTS_Context : DbContext
    {
        public OTS_Context() : base("DefaultConnection")
        {

        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<PaymentCard> PaymentCards { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Venue> Venues { get; set; }

    }
}