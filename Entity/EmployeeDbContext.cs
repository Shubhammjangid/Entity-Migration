using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AddEmployeeMigration.Entity
{
    public class EmployeeDbContext : DbContext
    {
        

        public DbSet<EmployeeInfo> EmployeeInformation {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= LAPTOP-C59IR2RT\SQLEXPRESS;Database=EMPMI;User ID=root;Password=Root@123;Trusted_Connection=True;");
        }
    }
}
