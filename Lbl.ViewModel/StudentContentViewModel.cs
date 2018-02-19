using Lbl.Model;
using Lbl.Model.Student;

namespace Lbl.ViewModel
{
    public class StudentContentViewModel : BaseViewModel<StudentContent>
    {
        public StudentContentViewModel(StudentContent studentContent) : base(studentContent)
        {
            this.WatchedContent = studentContent.WatchedContent;
            if (studentContent.Student != null)
            {
                this.Student=new StudentViewModel(studentContent.Student);
            }
            if (studentContent.Content != null)
            {
                this.Content=new ContentViewModel(studentContent.Content);
            }
        }


        public int WatchedContent { set; get; }
        public StudentViewModel Student { set; get; }
        public ContentViewModel Content { set; get; }

    }
}
