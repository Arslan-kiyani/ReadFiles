using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ReadFile_Mini.Interface;
using ReadFile_Mini.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ReadFile_Mini.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            // Validate the user credentials (for demo purposes, this is hard-coded)
            if (login.UserName == "test" && login.Password == "password")
            {
                var tokenString = _jwtService.GenerateToken(login.UserName);
                return Ok(new { Token = tokenString });
            }

            return Unauthorized();
        }
    }
}
