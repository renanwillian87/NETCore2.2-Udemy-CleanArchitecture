using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CleanArchitecture.Infra.Data.Context;
namespace CleanArchitecture.Infra.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<UniversityDBContext>
    {
        public UniversityDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityDBContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=CleanArchitecture.University;User Id=sa;Password=!123asw@;");
            return new UniversityDBContext(optionsBuilder.Options);
        }
    }
}