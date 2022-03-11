using System;
using System.ComponentModel.DataAnnotations;
using Web.Api.Models.Entities;

namespace Web.Api.Models
{
    public class UserModel : BaseEntity
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.-]+@[gmail|yandex]+.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Must be a valid email")]
        [StringLength(16,
            ErrorMessage = "Must be between 5 and 50 characters",
            MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
