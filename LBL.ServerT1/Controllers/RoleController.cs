using System;
using System.Web.Http;
using LBL.ServerT1.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LBL.ServerT1.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/Role")]
    public class RoleController : ApiController
    {
        public IHttpActionResult Post(RoleBindingModel role)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new IdentityDbContext()));
            var appUser = User.Identity;

            var applicationRole = new ApplicationRole(role.Name);
            applicationRole.LandingRoute = role.LandingRoute;
            applicationRole.Modified=DateTime.Now;
            applicationRole.ModifiedBy = appUser.Name;
            applicationRole.CreatedBy = appUser.Name;
            applicationRole.Created=DateTime.Now;
            var identityResult = roleManager.Create(applicationRole);
            if (!identityResult.Succeeded)
                return BadRequest("Failed to add application role");
            return Ok();
        }
    }
}
