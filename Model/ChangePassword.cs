using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla.Model
{
    public class ChangePassword
    {
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please put your old password")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DisplayName("NewPassword")]
        [Required(ErrorMessage = "Please put your new password")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$", ErrorMessage = "Password should contain at least: 8 characters, 1 uppercase letter, 1 lowercase letter, 1 number")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}