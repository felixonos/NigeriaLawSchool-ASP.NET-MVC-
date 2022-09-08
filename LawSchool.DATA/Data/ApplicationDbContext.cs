using LawSchool.Data.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LawSchool.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}