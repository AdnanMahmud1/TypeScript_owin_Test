using System.Web.Http;
using Lbl.Model;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace LBL.ServerT1.Controllers
{
    [RoutePrefix("api/content")]
    public class ContentController : BaseController<Content,ContentRequestModel,ContentViewModel>
    {
    }
}
