using BackendForex.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendForex.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            // Dummy user validation (replace with actual logic)
            if (model.Username == "test" && model.Password == "password")
            {
                var tokenGenerator = new JwtTokenGenerator(
                    _configuration["Jwt:Key"],
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"]);

                var token = tokenGenerator.GenerateToken(model.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
