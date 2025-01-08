using BackendForex.Data;
using BackendForex.DTO;
using BackendForex.Interfaces;
using BackendForex.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendForex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : ControllerBase
    {
        private readonly DataContext _conext;
        private readonly IWalletsService _walletsService;

        public WalletsController(DataContext context, IWalletsService walletsService)
        {
            _conext = context;
            _walletsService = walletsService;
        }

        [HttpGet("GetAllWallets")]
        public async Task<IActionResult> GetAllWallets()
        {
            var response = await _walletsService.GetAllWallets();
            return Ok(response);
        }

        public async Task<IActionResult> CreateWallet([FromBody] WalletsDTOModel walletDTOModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var creteWallet = await _walletsService.CreateWallet();
        }

    }    
}
