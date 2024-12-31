using BackendForex.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BackendForex.Interfaces
{
    public interface IUsersService
    {
        Task<List<UsersDTOModel>> GetAllUsers();
        Task<UsersDTOModel?> GetUserById(int id);
    }
}
