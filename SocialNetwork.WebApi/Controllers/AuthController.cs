using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Abstract;
using static SocialNetwork.Entities.DTOs.UserDTO;

namespace SocialNetwork.WebApi.Controllers;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService=authService;
        }
        //[AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login( LoginDTO login) //[FromBody]
        {
            var result=_authService.Login(login);
            if (result.Success)
            {
                return Ok(new {status=200, message=result.Message});
            }
            return BadRequest(result.Message);
        }

    [HttpPost("register")]
        public IActionResult Register(RegisterDTO register)
        {
            var result=_authService.Register(register);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
