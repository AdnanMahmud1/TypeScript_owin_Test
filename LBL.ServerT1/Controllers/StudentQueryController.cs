using System.Web.Mvc;
using Lbl.Model;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/StudentQuery")]
    public class StudentQueryController :BaseQueryController<Student,StudentRequestModel,StudentViewModel>
    {
        public StudentQueryController() : base(new ApplicationDbContext())
        {

        }
    }
}
