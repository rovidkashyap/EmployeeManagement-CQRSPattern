using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee.Core.Entities.Employee> employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Core.Entities.Employee>().HasData(
                new Core.Entities.Employee { EmployeeId = 1, Department = "HR", FirstName = "Rovid", LastName = "Kashyap", Email = "rvd.kashyap@gmail.com", Mobile = "9760828296" },
                new Core.Entities.Employee { EmployeeId = 2, Department = "IT", FirstName = "Andrew", LastName = "James", Email = "andrew.james@mail.com", Mobile = "8909371977" },
                new Core.Entities.Employee { EmployeeId = 3, Department = "Administration", FirstName = "Ferry", LastName = "Synes", Email = "ferry.synes@mail.com", Mobile = "9045326030" },
                new Core.Entities.Employee { EmployeeId = 4, Department = "HR", FirstName = "Methew", LastName = "Berry", Email = "methew.berry@mail.com", Mobile = "9456201030" });   

            base.OnModelCreating(modelBuilder);
        }
    }
}
