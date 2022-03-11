using System.Threading.Tasks;
using Web.Api.Models;
using Web.Api.Service.DTOs;

namespace Web.Api.Data.IRepositories
{
    public interface IUserRepository : IGenericRepository<UserModel>
    {
        Task<UserModel> UpdateAsync(UserUpdatingDto model);

        Task<UserModel> GetAsync(UserSignInDto signIn);
    }
}
