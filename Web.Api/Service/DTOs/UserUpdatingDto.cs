using Web.Api.Enums;
using Web.Api.Models;

namespace Web.Api.Service.DTOs
{
    public class UserUpdatingDto : UserRegisterDto
    {
        public long Id { get; set; }
    }
}
