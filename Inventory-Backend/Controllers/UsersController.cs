using Inventory_Backend.Models;
using Inventory_Backend.Models.User;
using Inventory_Backend.Services.IServices;

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Text.Json.Nodes;

namespace Inventory_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService) 
        { 
            _userService = userService;
        }

        #region User GetAll API
        [HttpPost("GetAll")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DataAndCountDto<UserDto>))]
        public async Task<IActionResult> GetAll(SearchFilter filter)
        {
            return Ok(await _userService.GetAll(filter));
        }
        #endregion

        #region User GetById API
        [HttpPost("GetById")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DataAndCountDto<UserDto>))]
        public async Task<IActionResult> GetById(Guid Id)
        {
            return Ok(await _userService.GetSingleUser(Id));
        }
        #endregion

        #region User Insert API
        [HttpPost("Add")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        public async Task<IActionResult> Add(UserModel data)
        {
            return Ok(await _userService.Add(data));
        }
        #endregion

        #region User Update API
        [HttpPut("Update")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        public async Task<IActionResult> Update(UserModel data)
        {
            return Ok(await _userService.Update(data));
        }
        #endregion

        #region User Delete API
        [HttpDelete("Delete")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        public async Task<IActionResult> Delete(Guid Id)
        {
            return Ok(await _userService.Delete(Id));
        }
        #endregion
    }
}
