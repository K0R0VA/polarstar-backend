using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Auth.Common;
using Common.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Auth.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IOptions<AuthOptions> _options;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(IOptions<AuthOptions> options, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _options = options;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpDto signUpDto)
        {
            var user = new User()
            {
                Email = signUpDto.Email, 
                UserName = signUpDto.Email,
                PhoneNumber = signUpDto.Phone,
                FirstName = signUpDto.Name,
                Surname = signUpDto.Surname,
            };
            var result = await _userManager.CreateAsync(user, signUpDto.Password);
            if (!result.Succeeded) return BadRequest();
            HttpContext.Response.Cookies.Append("PolarStar.Auth", GenerateJwt(signUpDto.Email));
            return NoContent();
        }
        
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            var result = await _signInManager
                .CheckPasswordSignInAsync(user, loginDto.Password, true);
            if (!result.Succeeded) return BadRequest();
            HttpContext.Response.Cookies.Append("PolarStar.Auth", GenerateJwt(loginDto.Email));
            return NoContent();
        }

        private string GenerateJwt(string email)
        {
            var authParams = _options.Value;
            var secretKey = authParams.GetSymmetricSecurityKey();
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>()
            {
                new (JwtRegisteredClaimNames.Email, email),
            };
            var token = new JwtSecurityToken(
                authParams.Issuer,
                authParams.Audience,
                claims,
                expires: DateTime.Now.AddSeconds(authParams.TokenLifetime),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
    
}