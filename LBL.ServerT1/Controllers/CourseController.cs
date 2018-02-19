using System.Web.Http;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/Course")]
    public class CourseController : BaseController<Course,CourseRequestModel,CourseViewModel>
    {
       
    }
}