using ExamBackEnd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExamBackEnd.Entities.DesignTime
{
    internal class DesignTimeApplicationDbContext : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=local.db");
            //optionsBuilder.UseOpenIddict();

            var db = new ApplicationDbContext(optionsBuilder.Options);
            return db;
        }
    }
}
