namespace DataAccess.Models;

public class Course
{
    public int Id { get; set; }
    public Teacher Teacher { get; set; } = null!;
    public ICollection<Student> Students { get; set; } = null!;

}