using ClassTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassTest.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
    }
}
