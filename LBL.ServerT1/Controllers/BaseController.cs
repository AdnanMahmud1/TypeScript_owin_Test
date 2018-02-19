using System;
using System.Web.Http;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.Service;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    public class BaseController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        [Route("Add")]
        [ActionName("Add")]
        [HttpPost]
        public IHttpActionResult Post(T model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            
            var service = new BaseService<T, TR, TV>();
            model.Id = Guid.NewGuid().ToString();
            var add = service.Add(model);
            return Ok(add);

        }
        
    }
}