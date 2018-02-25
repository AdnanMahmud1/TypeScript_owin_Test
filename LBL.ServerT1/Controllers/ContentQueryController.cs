using System.Web.Http;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/contentQuery")]
    public class ContentQueryController : BaseQueryController<Content,ContentRequestModel,ContentViewModel>
    {
        public ContentQueryController():base(new BusinessBdContext())
        {
            
        }
    }
}
