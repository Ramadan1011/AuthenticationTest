using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models;

public class RegistrationViewModel
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required.")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required.")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
    //[EmailAddress(ErrorMessage = "Please, Enter valid Email address.")]
    [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please, Enter valid Email address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "User name is required.")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Max 50 or Min 5 characters allowed.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Please confirm your password.")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Max 50 or Min 5 characters allowed.")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}
