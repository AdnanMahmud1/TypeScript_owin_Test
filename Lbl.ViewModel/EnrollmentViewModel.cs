using Lbl.Model;

namespace Lbl.ViewModel
{
    public class EnrollmentViewModel : BaseViewModel<Enrollment>
    {
        public EnrollmentViewModel(Enrollment enrollment) : base(enrollment)
        {
            IsPaid = enrollment.IsPaid;
            PaidTotal = enrollment.PaidTotal;
            Due = enrollment.Due;
            IsCompleted = enrollment.IsCompleted;
            CompletedContent = enrollment.CompletedContent;

            if (enrollment.Student != null)
            {
                Student = new StudentViewModel(enrollment.Student);
            }
            if (enrollment.Course != null)
            {
                Course = new CourseViewModel(enrollment.Course);
            }       
        }
        
        public bool IsPaid { get; set; }
        public double PaidTotal { get; set; }
        public double Due { get; set; }
        public bool IsCompleted { get; set; }
        public int CompletedContent { get; set; }
        public StudentViewModel Student { set; get; }
        public CourseViewModel Course { set; get; }

    }
}
