using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUDSystemMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CRUDSystemMVC.KS
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}