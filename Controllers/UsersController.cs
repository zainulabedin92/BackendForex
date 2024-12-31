using BackendForex.Data;
using BackendForex.DTO;
using BackendForex.Entities;
using BackendForex.Interfaces;
using BackendForex.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendForex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUsersService _userservice;

        public UsersController(DataContext context, IUsersService userService)
        {
            _context = context;
            _userservice = userService;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _userservice.GetAllUsers();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {

            var user = await _userservice.GetUserById(id);
            if (user is null)
                return NotFound("User Not Found");

            return Ok(user);
        }

          /*[HttpPost]
            public async Task<IActionResult> AddUser(UsersDTOModel usersDTOModel)
            {

                 var user = await _context.Users.FindAsync(id);
                 if (user is null)
                     return NotFound("User Not Found");

                 return Ok(user)
                return Ok("");
            };*/
    }
}
