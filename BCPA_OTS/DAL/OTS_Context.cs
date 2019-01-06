﻿using System;
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

        public DbSet<Person> People { get; set; }

        public DbSet<Staff> Staff { get; set; }
    }
}