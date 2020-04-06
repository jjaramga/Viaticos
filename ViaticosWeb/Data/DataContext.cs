﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViaticosWeb.Data.Entities;

namespace ViaticosWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<CityEntity> Cities { get; set; }

        public DbSet<CountryEntity> Countries { get; set; }

        public DbSet<ExpenseTypeEntity> ExpenseTypes { get; set; }


        public DbSet<TripDetailEntity> TripDetails { get; set; }

        public DbSet<TripEntity> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ExpenseTypeEntity>()
              .HasIndex(e => e.Name)
              .IsUnique();

            builder.Entity<CountryEntity>()
                .HasIndex(c => c.Name)
                .IsUnique();

            builder.Entity<CityEntity>()
                .HasIndex(cy => cy.Name)
                .IsUnique();
        }

    }
}
