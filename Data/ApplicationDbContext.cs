using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using address_book.Models;
using Microsoft.EntityFrameworkCore;

namespace address_book.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(c => c.Created)
                .ValueGeneratedOnAdd();
        }
    }
}