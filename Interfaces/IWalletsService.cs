using BackendForex.DTO;
using BackendForex.Entities;

namespace BackendForex.Interfaces
{
    public interface IWalletsService
    {
        Task<List<WalletsDTOModel>> GetAllWallets();
        Task<Wallets> CreateWallet(WalletsDTOModel walletDTOModel);
    }
}
