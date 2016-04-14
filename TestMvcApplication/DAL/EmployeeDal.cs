using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestMvcApplication.Models;

namespace TestMvcApplication.DAL
{
    public class EmployeeDal: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}