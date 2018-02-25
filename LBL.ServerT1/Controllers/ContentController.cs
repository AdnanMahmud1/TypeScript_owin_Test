using System.Web.Http;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;
using LBL.ServerT1.Models;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/Content")]
    public class ContentController : BaseController<Content, ContentRequestModel, ContentViewModel>
    {
        public ContentController() : base(new BusinessBdContext())
        {

        }
    }
}
