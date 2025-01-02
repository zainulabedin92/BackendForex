using System.ComponentModel.DataAnnotations;

namespace BackendForex.Entities
{
    public class Wallets
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string userId { get; set; }


        [Required]
        [MaxLength(22)]
        public string accountNo { get; set; }

        [Required]
        public string currencySign { get; set; }

        public bool isActive { get; set; }

        [MaxLength(200)]
        public double balance { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
