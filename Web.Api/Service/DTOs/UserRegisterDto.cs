using System;
using System.ComponentModel.DataAnnotations;
using Web.Api.Service.Attributes;

namespace Web.Api.Service.DTOs
{
    public class UserRegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(16,
           ErrorMessage = "Must be be0tween 5 and 50 characters",
           MinimumLength = 5)]
        [CheckEmail]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255,
            ErrorMessage = "Must be between 8 and 255 characters",
            MinimumLength = 8)]
        [DataType(DataType.Password)]
        [CheckPassword]
        public string Password { get; set; }
    }
}
