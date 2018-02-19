using System.Web.Mvc;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/Teacher")]
    public class TeacherController : BaseController<Teacher,TeacherRequestModel,TeacherViewModel>
    {
    }
}
