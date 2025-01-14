using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DBContext
{
    public class EFContext:DbContext
    {
        private string _connectionstring;
        public EFContext(string connectcionstring)
        {
            connectcionstring = _connectionstring;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(_connectionstring);
        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            //Define relationship between entities with has/with kind of relationship
            //one Company has many employees
            // modelBuilder.Entity<Company>()
            //     .HasMany(c => c.Employees)
            //     .WithOne(e => e.Company);
            //many employees has one Company
            // modelBuilder.Entity<Employee>()
            //     .HasOne(e => e.Company)
            //     .WithMany(c => c.Employees);
        }


        //Add Entites Below
    }
}
