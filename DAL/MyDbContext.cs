﻿using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=TestPomeloDb;user=root;password=",
                a => a.MigrationsAssembly("DAL"));
        }
    }
}
