using System.Web.Http;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.Service;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    public class BaseQueryController<T,TR,TV> : ApiController where T:Entity where TR:BaseRequestModel<T> where TV:BaseViewModel<T>
    {
        
        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Post(TR request)
        {
            var service = new BaseService<T, TR, TV>();
            var students = service.Search(request);
            return Ok(students);
        }
    }
}
