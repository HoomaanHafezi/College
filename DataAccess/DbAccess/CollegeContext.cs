using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbAccess;

public class CollegeContext : DbContext
{
    public CollegeContext()
    {

    }
    public CollegeContext(DbContextOptions<CollegeContext> options) : base(options)
    {

    }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Grade> Grades { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(g => new { g.StudentId, g.CourseId });
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,11433;Database=CollegeDB;User Id=sa;Password=Pwd1234!;");
        }
    }
}