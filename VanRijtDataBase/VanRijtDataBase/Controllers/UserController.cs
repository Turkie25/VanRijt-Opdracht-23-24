using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VanRijtDataBase.Dtos.User;

namespace VanRijtDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetUserDto>>>> GetUsers()
        {
            return Ok( await _userService.GetUsers());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> GetUserById(int Id)
        {
            return Ok(await _userService.GetUserById(Id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<User>>> PostUser(User newUser) 
        { 
            return  Ok(await _userService.PostUser(newUser));
        }
    }

}

