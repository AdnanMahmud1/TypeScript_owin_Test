using System.Web.Mvc;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/enrollment")]
    public class EnrollmentController : BaseController<Enrollment,EnrollmentRequestModel,EnrollmentViewModel>
    {
    }
}
