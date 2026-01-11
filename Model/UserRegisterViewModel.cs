using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla.Model
{
    public class UserRegisterViewModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Must enter first name")]
        [StringLength(72, ErrorMessage = "Too long first Name, max 72 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Must enter last name")]
        [StringLength(72, ErrorMessage = "Too long last Name, max 72 characters")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Enter email")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "Too long last Name, max 100 characters")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Enter your phone number")]
        [StringLength(12, ErrorMessage = "Too long last Name, max 12")]
        [Phone]
        public string PhoneNumber { get; set; }

        [DisplayName("User name")]
        [Required(ErrorMessage = "Must enter username")]
        [StringLength(36, ErrorMessage = "Too long username, max 36 characters")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Put password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password")]//ska matcha password
        public string ConfirmPassword { get; set; }
    }
}
