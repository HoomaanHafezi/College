using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Grade
{
    [Range(0, 20)]
    public double Value { get; set; }
    [ForeignKey("StudentId")]
    public Student Student { get; set; } = null!;
    public string StudentId { get; set; } = null!;
    public Course Course { get; set; } = null!;
    public int CourseId { get; set; }

}
