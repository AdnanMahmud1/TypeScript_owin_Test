using System.Data.Entity;
using System.Web.Mvc;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/enrollment")]
    public class EnrollmentController : BaseController<Enrollment,EnrollmentRequestModel,EnrollmentViewModel>
    {
        public EnrollmentController() : base(new BusinessBdContext())
        {
        }
    }
}
