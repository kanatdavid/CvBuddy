using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bla.Model.CvInfo
{
    public class PersonalCharacteristicVM
    {

        public int PCId { get; set; }

        [DisplayName("Personal Characteristic name")]
        [Required(ErrorMessage = "An added personal characteristic cannot be left empty.")]
        [StringLength(90, MinimumLength = 3)]
        public string CharacteristicName { get; set; }

    }
}
