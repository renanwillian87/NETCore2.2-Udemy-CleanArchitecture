using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace CleanArchitecture.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}