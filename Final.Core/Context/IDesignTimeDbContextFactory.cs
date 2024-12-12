using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Final.Core.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FinalContext>
    {
        public FinalContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FinalContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FinalDB;Trusted_Connection=True;");
            return new FinalContext(optionsBuilder.Options);
        }
    }
}
