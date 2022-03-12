using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public abstract class User
{
    [Key]
    [RegularExpression(@"[0-9]{10}", ErrorMessage = "National Id should be a ten digit number, Without whitespace or any other characters.")]
    public string NationalId { get; set; } = string.Empty;
    [Required]
    [MaxLength(20)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [MaxLength(20)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
    [Required]
    public string Salt { get; set; } = string.Empty;
    [Required]
    public string Role { get; set; } = string.Empty;
}