using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla.Model
{
    public class UserViewModel
    {
        public string UserId { get; set; } = string.Empty;

        [DisplayName("User Name")]
        [Required(ErrorMessage = "User name is Required")]
        public string UserName { get; set; } = string.Empty;

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is Required")]
        public string FirstName { get; set; } = string.Empty;

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is Required")]
        public string LastName { get; set; } = string.Empty;

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid email formaat")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        public AddressViewModel? AddressVm { get; set; }
    }
}
