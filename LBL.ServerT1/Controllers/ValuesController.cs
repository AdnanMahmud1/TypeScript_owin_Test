using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Lbl.Model;
using LBL.ServerT1.Models;
using Microsoft.AspNet.Identity.Owin;

namespace LBL.ServerT1.Controllers
{
   
    public class ValuesController : ApiController
    {
        [AllowAnonymous]
        public string Get()
        {
            return Guid.NewGuid().ToString();
        }
        // GET api/values
        //public async Task<ApplicationUser> Get()
        //{
        //    var userManager = this.Request.GetOwinContext().Get<ApplicationUserManager>();
        //    string name = User.Identity.Name;
        //    var appUser =await userManager.FindByNameAsync(name);
        //    ApplicationDbContext db1=ApplicationDbContext.Create();
        //    ApplicationUser user = db1.Users.FirstOrDefault(x=>x.UserName==name);
        //    BusinessBdContext db2=BusinessBdContext.Create();

        //    return appUser;
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
