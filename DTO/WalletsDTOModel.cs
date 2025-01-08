using System.ComponentModel.DataAnnotations;

namespace BackendForex.DTO
{
    public class WalletsDTOModel
    {
        public string userId { get; set; }
        public string accountNo { get; set; }
        public string currencySign { get; set; }
        public bool isActive { get; set; }
        public double balance { get; set; }
    }
}
