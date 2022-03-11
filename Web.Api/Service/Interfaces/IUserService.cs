using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Web.Api.Models;
using Web.Api.Models.Common;
using Web.Api.Service.DTOs;

namespace Web.Api.Service.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> CreateAsync(UserRegisterDto model);

        Task<UserModel> UpdateAsync(UserModel model);

        Task<UserModel> UpdateAsync(UserUpdatingDto model);

        Task<bool> DeleteAsync(Expression<Func<UserModel, bool>> expression);

        Task<IEnumerable<UserModel>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<UserModel, bool>> expression = null);

        Task<BaseResponse<UserModel>> GetAsync(Expression<Func<UserModel, bool>> expression);

        Task<BaseResponse<UserModel>> GetAsync(UserSignInDto signIn);
    }
}
