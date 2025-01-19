using BackendForex.Data;
using BackendForex.Interfaces;
using BackendForex.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendForex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly IUsersService _userServce;

        public AuthController(DataContext dbContext, IConfiguration configuration, IUsersService usersService)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _userServce = usersService;
        }
        
    }
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
