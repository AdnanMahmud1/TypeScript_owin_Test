using System.Web.Mvc;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/TeacherQuery")]
    public class TeacherQueryController : BaseQueryController<Teacher, TeacherRequestModel,TeacherViewModel>
    {
        public TeacherQueryController() : base(new ApplicationDbContext())
        {
        }
    }
}
