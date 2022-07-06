using Microsoft.EntityFrameworkCore;

namespace CQRS_.Net_5_.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student(){Id=1,Name="Furkan",age=29,Surname="Çiftci"} ,
                new Student(){Id=2,Name="Gökhan",age=24,Surname="Çiftci"} ,
                new Student(){Id=3,Name="Hakan",age=39,Surname="Çiftci"}
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
