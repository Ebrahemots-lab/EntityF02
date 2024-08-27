using DemoEF01.Configration;
using DemoEF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF01.Context
{
    internal class CompanyContext : DbContext
    {
        //Start connection between EFCORE AND SQL Server

        public CompanyContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = . ; Database = FCompany ; Trusted_Connection = true");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
        }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
