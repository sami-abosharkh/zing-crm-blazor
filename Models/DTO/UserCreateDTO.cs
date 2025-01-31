﻿using System.ComponentModel.DataAnnotations;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Models.DTO
{
    public class UserCreateDTO
    {
        [Required]
        [Display(Name = "first name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; } = SD.Role_ClientService;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
