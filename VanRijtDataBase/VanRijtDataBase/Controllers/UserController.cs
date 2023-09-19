using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



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
        public async Task<ActionResult<ServiceResponce<List<User>>>> GetUsers()
        {
            return Ok( await _userService.GetUsers());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponce<User>>> GetUserById(int Id)
        {
            return Ok(await _userService.GetUserById(Id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponce<User>>> PostUser(User newUser) 
        { 
            return  Ok(await _userService.PostUsers(newUser));
        }
    }

}

