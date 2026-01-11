using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla.Model
{
    public class LoginViewModel
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage ="UserName can not be empty")]
        [StringLength(72)]
        public string UserName { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password can not be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
