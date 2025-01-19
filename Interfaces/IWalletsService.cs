using BackendForex.DTO;
using BackendForex.Entities;
using BackendForex.Services;

namespace BackendForex.Interfaces
{
    public interface IWalletsService
    {
        Task<List<WalletsGetModel>> GetAllWallets();
        Task<Wallets> CreateWallet(WalletsDTOModel walletDTOModel);
    }
}
