using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Api.Models;
using Web.Api.Service.Interfaces;
using Web.Api.Service.ViewModels;

namespace Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public Task<UserModel> Create([FromForm]UserForCreationViewModel model)
        {
            return _userService.CreateAsync(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int pageSize, int pageIndex)
        {
            return Ok(await _userService.GetAllAsync(pageSize, pageIndex));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var result = await _userService.GetAsync(p => p.Id.Equals(id));

            return result.Error?.Code == 404 ? NotFound(result) : Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetInfo([FromQuery]SignInModel signIn)
        {
            var result = await _userService.GetAsync(signIn);

            return result.Error?.Code == 404 ? NotFound(result) : Ok(result);
        }

        [HttpDelete("{id}")]
        public Task<bool> Delete(long id)
        {
            return _userService.DeleteAsync(p => p.Id.Equals(id));
        }

        [HttpPut]
        public Task<UserModel> Update([FromForm]UserModel user)
        {
            return _userService.UpdateAsync(user);
        }

        [HttpPatch]
        public Task<UserModel> Update([FromForm]UserForPatchingViewModel model)
        {
            return _userService.UpdateAsync(model);
        }

    }
}
