using BackendForex.Controllers;
using BackendForex.Data;
using BackendForex.DTO;
using BackendForex.Entities;
using BackendForex.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendForex.Services
{
    public class WalletsService:IWalletsService
    {
        private readonly DataContext _context;
        
        public WalletsService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<WalletsGetModel>> GetAllWallets()
        {
            return await _context.Wallets
                .Select(Wallets => new WalletsGetModel
                {
                    Id = Wallets.Id,
                    userId = Wallets.userId,
                    currencySign =Wallets.currencySign,
                    balance = Wallets.balance,
                    accountNo = Wallets.accountNo,
                    isActive = Wallets.isActive,
                }).ToListAsync();
        }

        public async Task<Wallets> CreateWallet(WalletsDTOModel walletDTOModel)
        {
            var newWallet = new Wallets
            {
                userId = walletDTOModel.userId,
                balance = walletDTOModel.balance,
                accountNo = walletDTOModel.accountNo,
                currencySign = walletDTOModel.currencySign,
                isActive = walletDTOModel.isActive,
                CreatedDate = new DateTime(),
                UpdatedDate = new DateTime(),
            };
            _context.Add(newWallet);
            await _context.SaveChangesAsync();
            return newWallet;
        }
    }
    public class WalletsGetModel
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public string accountNo { get; set; }
        public string currencySign { get; set; }
        public bool isActive { get; set; }
        public double balance { get; set; }
    }
}
