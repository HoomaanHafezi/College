namespace DataAccess.Models;

public class Teacher : User
{
    public Teacher()
    {
        Role = "Teacher";
    }

    public ICollection<Course> Courses { get; set; } = null!;
}