using System.Web.Http;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/EnrollmentQuery")]
    public class EnrollmentQueryController : BaseQueryController<Enrollment,EnrollmentRequestModel,EnrollmentViewModel>
    {
        public EnrollmentQueryController():base(new BusinessBdContext())
        {
            
        }
    }
}
