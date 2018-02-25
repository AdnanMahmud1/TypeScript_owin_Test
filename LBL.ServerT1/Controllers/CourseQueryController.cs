using System.Web.Http;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/CourseQuery")]
    public class CourseQueryController : BaseQueryController<Course,CourseRequestModel,CourseViewModel>
    {
        public CourseQueryController() : base(new BusinessBdContext())
        {
            
        }
    }
}
