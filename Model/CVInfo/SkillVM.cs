using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bla.Model.CvInfo
{
    public class SkillVM
    {
        public int Sid { get; set; }

        [DisplayName("Skill name")]

        [Required(ErrorMessage = "You need to enter what the skill is.")] 
        public string ASkill { get; set; }

        [StringLength(90)]
        public string? Description { get; set; }

        [Range(typeof(DateTime), "1900-01-01", "2049-12-31", ErrorMessage = "Date can only be after year 1900 and before year 2050.")]
        public DateTime? Date { get; set; }

    }
}
