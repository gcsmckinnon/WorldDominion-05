﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorldDominion.Models;

namespace WorldDominion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}