using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<NumberEntry> NumberEntries { get; set; }
    }
}

