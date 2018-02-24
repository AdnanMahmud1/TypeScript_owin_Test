using System;
using System.Web.Http;
using Lbl.Model.Student;
using Lbl.RequestModel;
using Lbl.Service;
using Lbl.ViewModel;
using Microsoft.AspNet.Identity;

namespace LBL.ServerT1.Controllers
{
    public class BaseController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        private BaseService<T, TR, TV> service;

        public BaseController(System.Data.Entity.DbContext dbContext)
        {
            service = new BaseService<T, TR, TV>(dbContext);
        }
        [Route("Add")]
        [ActionName("Add")]
        [HttpPost]
        public IHttpActionResult Add(T model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            //var service = new BaseService<T, TR, TV>();
            //model.Id = Guid.NewGuid().ToString();
            //var add = service.Add(model);
            //return Ok(add);
            model.ModifiedBy = User.Identity.GetUserName();
            model.CreatedBy = User.Identity.GetUserName();

            model.Id = Guid.NewGuid().ToString();

            var add = service.Add(model);
            return this.Ok(add);
        }
        
    }
}