using Lbl.Model.Student;

namespace Lbl.ViewModel
{
    public class StudentViewModel : BaseViewModel<Student>
    {
        public StudentViewModel(Student student):base(student)
        {
            Name = student.Name;
            Phone = student.Phone;
            Address = student.Address;
        }
        public string Name { get; set; }
        public string Phone { set; get; }
        public string Address { get; set; }
    }

    //public class StudentViewModel:BaseViewModel<Student>
    //{
    //    public StudentViewModel(Entity entity) : base(entity)
    //    {
    //    }
    //}
}