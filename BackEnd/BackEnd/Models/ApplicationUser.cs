using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace BackEnd.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        [DataType(DataType.Text)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        [DataType(DataType.Text)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string ImageUrl { get; set; }

        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
