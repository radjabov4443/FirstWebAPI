using System;
using System.ComponentModel.DataAnnotations;
using Web.Api.Models.Entities;

namespace Web.Api.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255,
            ErrorMessage = "Must be between 5 and 255 characters",
            MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        public string Password { get; set; }

    }
}
