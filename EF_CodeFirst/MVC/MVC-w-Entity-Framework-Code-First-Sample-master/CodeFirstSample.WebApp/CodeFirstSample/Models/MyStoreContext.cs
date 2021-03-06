﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstSample.Models
{
    public class MyStoreContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                 .ToTable("Customer")
                .HasKey(c => c.CustomerId);

        }

    }
}