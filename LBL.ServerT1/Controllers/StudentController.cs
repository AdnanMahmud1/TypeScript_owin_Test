using System.Web.Http;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/Student")]
    public class StudentController : BaseController<Student, StudentRequestModel,StudentViewModel>
    {
        public StudentController():base(new ApplicationDbContext())
        {
            
        }
    }
    //[RoutePrefix("api/Student")]
    //public class StudentController : ApiController
    //{
    //    public IHttpActionResult Post(Student student)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return this.BadRequest(ModelState);
    //        }
    //        StudentService service=new StudentService(); // this is used to later understand the code
    //        var add = service.Add(student);
    //        return Ok(add);

    //    }
    //}
}
