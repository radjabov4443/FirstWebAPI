using Web.Api.Enums;
using Web.Api.Models;

namespace Web.Api.Service.ViewModels
{
    public class UserForPatchingViewModel : SignInModel
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
