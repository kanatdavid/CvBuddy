using bla.Model;
using bla.Model.CvInfo;

namespace bla.Model
{ 
    public class ProfileViewModel
    {
        public User? ViewUser { get; set; }
        public Cv? Cv { get; set; }
        public List<ProjectVM> Projects { get; set; } = new();
    }
}
