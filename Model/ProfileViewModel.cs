using bla.Model;
using bla.Model.CvInfo;

namespace bla.Model
{ 
    public class ProfileViewModel
    {
        public User? ViewUser { get; set; } //måste vara nullable men kan aldrig bli null, alla profiler har en user
        public Cv? Cv { get; set; }
        public List<ProjectVM> Projects { get; set; } = new();
    }
}
