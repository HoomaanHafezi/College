using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class Student : User
{
    public Student()
    {
        Role = "Student";
    }

    public double GPA { get; set; }

    public ICollection<Course> Courses { get; set; } = null!;

}