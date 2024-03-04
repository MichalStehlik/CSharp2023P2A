using CSharp19LINQ_DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp19LINQ_DB.Data
{
    internal class ApplicationDbContext : DbContext
    {
        private string _connectionString;

        public ApplicationDbContext()
        {
            _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine, new[]
            {
                RelationalEventId.CommandExecuted
            });
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(new CSharp19LINQ_DB.Models.Student { Id = -1, Firstname = "Eva", Lastname = "Černá" });
        }

        public DbSet<Student> Students { get; set; }
    }
}
/*
 * Add-Migration Init
 * Update-Database
 */