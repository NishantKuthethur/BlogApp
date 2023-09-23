using System.ComponentModel.DataAnnotations;
namespace blogCloneAPI.Models{
    public class User{
        [Required]
        public int UserID{ get; set;}

        [Required]
        public string Username { get; set;}

        [Required]
        [EmailAddress]
        public string Email { get; set;}

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }
}
