using System;
using System.ComponentModel.DataAnnotations;
using Web.Api.Models;

namespace Web.Api.Service.DTOs
{
    public class UserRegisterDto : UserSignInDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.-]+@[gmail|yandex]+.[a-zA-Z0-9-.]+$",
           ErrorMessage = "Must be a valid email")]
        [StringLength(16,
           ErrorMessage = "Must be between 5 and 50 characters",
           MinimumLength = 5)]
        public string Email { get; set; }
    }
}
