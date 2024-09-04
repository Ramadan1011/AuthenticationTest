﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AuthTest.Entities;

[Index(nameof(Email), IsUnique = true)]
[Index(nameof(Username), IsUnique = true)]
public class UserAccount
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed")]
    public string Email { get; set; }   

    [Required(ErrorMessage = "User name is required")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MaxLength(50, ErrorMessage = "Max 50 characters allowed")]
    public string Password { get; set; } 
}
