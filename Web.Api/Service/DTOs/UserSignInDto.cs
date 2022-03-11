using System.ComponentModel.DataAnnotations;
using Web.Api.Service.Services;

namespace Web.Api.Service.DTOs
{
    public class UserSignInDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        private string hashPassword;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255,
            ErrorMessage = "Must be between 8 and 255 characters",
            MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        public string Password
        {
            get { return hashPassword; }
            set { hashPassword = PasswordHash.Create(value); }
        }
    }
}
