using System.Web.Mvc;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/StudentQuery")]
    public class StudentQueryController :BaseQueryController<Student,StudentRequestModel,StudentViewModel>
    {
    }
}
