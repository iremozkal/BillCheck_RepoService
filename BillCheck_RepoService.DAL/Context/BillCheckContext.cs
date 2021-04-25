using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillCheck_RepoService.DATA.Model_Entity;
using BillCheck_RepoService.DAL.Mapping;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BillCheck_RepoService.DAL.Context
{
    public class BillCheckContext : DbContext
    {
        public BillCheckContext()
            : base("Server=.; Database=BillCheckDB; Integrated Security=SSPI")
        {

        }

        // After creating Model_Enttiy classes, create the tables below according to entities.

        public DbSet<Employee> EmployeeTable { get; set; }
        public DbSet<Order> OrderTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<Table> TableTable { get; set; }

        // Go to create mapping classes. Then go back here.
        // enable-migrations
        // Add mapping classes below inside the OnModelCreating() method.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        // update-database to create database.
    }
}
