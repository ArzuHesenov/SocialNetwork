using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using SocialNetwork.Business.Abstract;
using System.IdentityModel.Tokens.Jwt;

namespace SocialNetwork.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [Authorize]
        [HttpGet("getuser/{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            return Ok(_userService.GetUserByEmail(email));
        }
        [Authorize]
        [HttpGet("profilepost")]
        public IActionResult GetUserProfilePost()
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var id = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;
            var result = _userService.GetProfilePost(Guid.Parse(id));
            return Ok(result.Data);
        }

        [Authorize]
        [HttpGet("dislikepost")]
        public IActionResult GetUserDisLikePost()
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var id = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;
            var result = _userService.GetDisLikePost(Guid.Parse(id));
            return Ok(result.Data);
        }
    }
}
