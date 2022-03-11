using System.Threading.Tasks;
using Web.Api.Models;
using Web.Api.Service.ViewModels;

namespace Web.Api.Data.IRepositories
{
    public interface IUserRepository : IGenericRepository<UserModel>
    {
        Task<UserModel> UpdateAsync(UserForPatchingViewModel model);

        Task<UserModel> GetAsync(SignInModel signIn);
    }
}
