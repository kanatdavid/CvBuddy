using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bla.Model.CvInfo
{
    public class ExperienceVM
    {
        public int Exid { get; set; }
        
        [Required(ErrorMessage = "You need to enter what the experience title is, don't leave empty.")] 
        [StringLength(90, MinimumLength = 3)]
        public string Title { get; set; } = "";

        [StringLength(120)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Don't leave company field empty, if it was a freelance experience enter ''Freelance''.")] 
        public string Company { get; set; } = "";

        [DisplayName("Start Date")]
        [Required(ErrorMessage = "An added experience must have a start date, dont leave unentered.")]
        [Range(typeof(DateTime), "1900-01-01", "2049-12-31", ErrorMessage = "Date can only be after year 1900 and before year 2050.")]

        public DateTime? StartDate { get; set; }
        
        [DisplayName("End Date")]
        [Range(typeof(DateTime), "1900-01-01", "2049-12-31", ErrorMessage = "Date can only be after year 1900 and before year 2050.")]
        public DateTime? EndDate { get; set; }

    }
}
