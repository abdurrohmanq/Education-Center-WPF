using EduCenter.Desktop.Entities.Attandances;
using EduCenter.Desktop.Entities.Courses;
using EduCenter.Desktop.Entities.Employees;
using EduCenter.Desktop.Entities.Groups;
using EduCenter.Desktop.Entities.Lessons;
using EduCenter.Desktop.Entities.Positions;
using EduCenter.Desktop.Entities.Rooms;
using EduCenter.Desktop.Entities.Students;
using EduCenter.Desktop.Entities.Teachers;
using Microsoft.EntityFrameworkCore;

namespace EduCenter.Desktop.DbContexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string connectionString = "host=localhost; uid=postgres; password=root; database=EduCenterDb;";

        optionsBuilder.UseNpgsql(connectionString);
    }

    public DbSet<Group> Groups { get; set;}
    public DbSet<Room> Rooms { get; set;}
    public DbSet<Course> Courses { get; set;}
    public DbSet<Lesson> Lessons { get; set;}
    public DbSet<Student> Students { get; set;}
    public DbSet<Teacher> Teachers { get; set;}
    public DbSet<Position> Positions { get; set;}
    public DbSet<Employee> Employees { get; set;}
    public DbSet<Attandance> Attandances { get; set;}
    public DbSet<GroupDetail> GroupDetail { get; set;}
    public DbSet<GroupTeacher> GroupTeachers { get; set;}
    public DbSet<GroupStudent> GroupStudents { get; set;}
    public DbSet<StudentPayment> StudentPayment { get; set;}
}
