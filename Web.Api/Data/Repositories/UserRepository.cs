using System;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Data.Contexts;
using Web.Api.Data.IRepositories;
using Web.Api.Enums;
using Web.Api.Models;
using Web.Api.Service.DTOs;
using Web.Api.Service.Services;

namespace Web.Api.Data.Repositories
{
#pragma warning disable
    public class UserRepository : GenericRepository<UserModel>, IUserRepository
    {
        public UserRepository(TestDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<UserModel> GetAsync(UserSignInDto signIn)
        {
            var user = _dbSet.FirstOrDefault(
                p => p.Password == PasswordHash.Create(signIn.Password)
                && p.Username == signIn.Username);

            return user;
        }

        public async Task<UserModel> UpdateAsync(UserUpdatingDto model)
        {
            var user = await _dbSet.FindAsync(model.Id);

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.State = ItemState.Updated;
            user.EditedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return user;
        }
    }
}
