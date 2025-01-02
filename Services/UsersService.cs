using BackendForex.Data;
using BackendForex.DTO;
using BackendForex.Entities;
using BackendForex.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendForex.Services
{
    
    public class UsersService: IUsersService
    {
        private readonly DataContext _context;

        public UsersService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<UsersDTOModel>> GetAllUsers()
        {
            return await _context.Users
                 .Select(user => new UsersDTOModel
                 {
                     FirstName = user.FirstName,
                     LastName = user.LastName,
                     Email = user.Email,
                     Country = user.Country,
                     City = user.City,
                     PhoneNumber = user.PhoneNumber,
                     UserType = user.UserType,
                     StreetAddress = user.StreetAddress,
                     //ProfileImage = user.ProfileImage
                 }).ToListAsync();
        }

        public async Task<UsersDTOModel?> GetUserById(int id)
        {
            return await _context.Users
                .Where(user => user.Id == id)
                .Select(user => new UsersDTOModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Country = user.Country,
                    City = user.City,
                    PhoneNumber = user.PhoneNumber,
                    UserType = user.UserType,
                    StreetAddress = user.StreetAddress,
                    //ProfileImage = user.ProfileImage
                }).FirstOrDefaultAsync();
        }

        public async Task<Users> CreateUserAsync(UsersDTOModel usersDTOModel)
        {
            var newUser = new Users
            {
                FirstName = usersDTOModel.FirstName,
                LastName = usersDTOModel.LastName,
                Email = usersDTOModel.Email,
                Password = usersDTOModel.Password,
                Country = usersDTOModel.Country,
                City = usersDTOModel.City,
                StreetAddress = usersDTOModel.StreetAddress,
                Verify = usersDTOModel.Verify,
                PhoneNumber = usersDTOModel.PhoneNumber,
                DateOfBirth = usersDTOModel.DateOfBirth,
                //ProfileImage = usersDTOModel.ProfileImage,
                UserType = usersDTOModel.UserType,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }
    }
}
