using System.ComponentModel;

namespace Nvh_Th2_Lab04.Models
{
    public class Learner
    {
        public Learner() {
            Enrollments = new HashSet<Enrollment>();
        }
        [DisplayName("Mã")]
        public int LearnerId {  get; set; }
        [DisplayName("Tên")]
        public string LastName {  get; set; }
        [DisplayName("Họ")]
        public string FirstMidName {  get; set; }
        [DisplayName("Ngày nhập học")]
        public DateTime EnrollmentDate { get; set; }
        public int MajorID {  get; set; }
        public virtual Major? Major {  get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
