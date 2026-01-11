using bla.Model;
using bla.Model.CvInfo;
using System.ComponentModel.DataAnnotations.Schema;

namespace bla.Model
{
    public class CvProject
    {
        public int CvId { get; set; }
        [ForeignKey(nameof(CvId))]
        public Cv OneCv { get; set; }

        public int ProjId { get; set; }
        [ForeignKey(nameof(ProjId))]
        public Project OneProject { get; set; }
    }
}
