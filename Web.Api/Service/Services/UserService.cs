using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Web.Api.Data.IRepositories;
using Web.Api.Models;
using Web.Api.Models.Common;
using Web.Api.Service.Extensions;
using Web.Api.Service.Interfaces;
using Web.Api.Service.DTOs;

namespace Web.Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<UserModel> CreateAsync(UserRegisterDto model)
        {
            UserModel user = new UserModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Birthday = model.Birthday,
                Email = model.Email,
                Password = model.Password,
                Username = model.Username
            };

            return _userRepository.CreateAsync(user);
        }

        public Task<bool> DeleteAsync(Expression<Func<UserModel, bool>> expression)
        {
            return _userRepository.DeleteAsync(expression);
        }

        public async Task<IEnumerable<UserModel>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<UserModel, bool>> expression = null)
        {
            var users = await _userRepository.GetAllAsync(expression);

            return users.ToPagenation(pageSize, pageIndex);
        }

        public async Task<BaseResponse<UserModel>> GetAsync(Expression<Func<UserModel, bool>> expression)
        {
            var response = new BaseResponse<UserModel>();

            var user = await _userRepository.GetAsync(expression);

            if(user is null)
            {
                response.Error = new ErrorModel(404, "User not found!");
                return response;
            }

            response.Data = user;

            return response;
        }

        public async Task<BaseResponse<UserModel>> GetAsync(UserSignInDto signIn)
        {
            var response = new BaseResponse<UserModel>();

            var user = await _userRepository.GetAsync(signIn);

            if(user is null)
            {
                response.Error = new ErrorModel(404, "User not found!");
                return response;
            }

            response.Data = user;

            return response;
        }

        public Task<UserModel> UpdateAsync(UserModel model)
        {
            return _userRepository.UpdateAsync(model);
        }

        public Task<UserModel> UpdateAsync(UserUpdatingDto model)
        {
            return _userRepository.UpdateAsync(model);
        }
    }
}
