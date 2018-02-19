using Lbl.Model;
using Lbl.Model.Student;

namespace Lbl.ViewModel
{
    public class TeacherViewModel:BaseViewModel<Teacher>
    {
        public TeacherViewModel(Teacher teacher) : base(teacher)
        {
            this.Name = teacher.Name;
        }
        public string Name { get; set; }
    }
}