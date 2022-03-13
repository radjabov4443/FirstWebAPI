using System.ComponentModel.DataAnnotations;
using Web.Api.Service.Attributes;
using Web.Api.Service.Services;

namespace Web.Api.Service.DTOs
{
    public class UserSignInDto
    {
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
