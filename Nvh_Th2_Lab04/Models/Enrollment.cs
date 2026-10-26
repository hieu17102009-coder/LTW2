namespace Nvh_Th2_Lab04.Models
{
    public class Enrollment
    {
        public int EnrollmentID {  get; set; }
        public int CouresID {  get; set; }
        public int LearnerID {  get; set; }
        public float Grade {  get; set; }
        public virtual Learner? Learner{ get; set; }
        public virtual Course? Coure{ get; set; }
    }
}
