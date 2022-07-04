using Microsoft.EntityFrameworkCore;

namespace CQRS_.Net_5_.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
