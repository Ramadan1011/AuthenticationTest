using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "Username or Email is required.")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
    [DisplayName("Username or Email")]
    public string UsernameOrEmail { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Max 50 or Min 5 characters allowed.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
