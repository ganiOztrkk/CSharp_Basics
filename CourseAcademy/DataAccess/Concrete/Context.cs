using Entity.Concete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //connection string - veritabanı bağlantımı tutacak.
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=CourseAcademyDb; User Id=sa; Password=148951753Gg(.);TrustServerCertificate=True; Encrypt=false");
    }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Course>? Courses { get; set; }
    public DbSet<Instructor>? Instructors { get; set; }
}
