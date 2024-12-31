namespace BackendForex.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(200)]
        public string StreetAddress { get; set; }

        public bool Verify { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public string ProfileImage { get; set; } // Store image URL or path

        [Required]
        [MaxLength(20)]
        public string UserType { get; set; } // Example: "Admin", "User", etc.

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

}
