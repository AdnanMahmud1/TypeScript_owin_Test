using System.Web.Http;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.Service;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    public class BaseQueryController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        private BaseService<T, TR, TV> service;

        public BaseQueryController(System.Data.Entity.DbContext dbContext)
        {
            service = new BaseService<T, TR, TV>(dbContext);
        }

        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Search(TR request)
        {
            var students = service.Search(request);
            return this.Ok(students);
        }
    }
}
