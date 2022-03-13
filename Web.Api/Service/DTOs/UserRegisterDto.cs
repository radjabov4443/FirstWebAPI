using System;
using System.ComponentModel.DataAnnotations;
using Web.Api.Models;
using Web.Api.Service.Attributes;

namespace Web.Api.Service.DTOs
{
    public class UserRegisterDto : UserSignInDto
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
    }
}
