using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeFinance.Controllers
{
    [Authorize(Roles="Admin")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJwtAuthenticationManager JwtAuthenticationManager;

        public UserController(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.JwtAuthenticationManager = jwtAuthenticationManager;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Arup", "Mohanty" };
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User user)
        {
            var token = JwtAuthenticationManager.Authenticate(user.UserName, user.Password);
            if (token == null)
                return BadRequest("Incorrect user name or password!");
            return Ok(token);
        }

        [AllowAnonymous]
        [HttpPost("refresh")]
        public IActionResult RefreshToken([FromBody] RefreshTokenInfo refreshTokenInfo)
        {
            var token = JwtAuthenticationManager.RefreshToken(refreshTokenInfo);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
