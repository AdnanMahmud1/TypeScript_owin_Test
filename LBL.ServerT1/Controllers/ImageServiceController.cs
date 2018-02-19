using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using Lbl.Service;

namespace LBL.ServerT1.Controllers
{
    public class ResponseModel
    {
        public ResponseModel(object data = null, bool isSuccess = true, string message = "Success", Exception exception = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            Exception = exception;
        }
        public Exception Exception { set; get; }
        public Object Data { set; get; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    //[AllowAnonymous]
    public class ImageServiceController : ApiController
    {
        //[HttpGet]
        //[Route("api/image/profileImage")]
        public HttpResponseMessage Get(string imageName, int type = 0, int stamp = 0)
        {
            var root = FileCheckingManager.TestProjectFileLocation(2);
            HttpResponseMessage result;
            switch (type)
            {
                case 0:
                    root = FileCheckingManager.TestProjectFileLocation(0) + imageName;
                    break;
                case 1:
                    root = FileCheckingManager.TestProjectFileLocation(1) + imageName;
                    break;
            }
            try
            {
                if (!File.Exists(root))
                {
                    root = FileCheckingManager.TestProjectFileLocation(2);
                }

                result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new StreamContent(new FileStream(root, FileMode.Open, FileAccess.Read));
                result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                result.Content.Headers.ContentDisposition.FileName = "ProfileImage";
            }
            catch (Exception e)
            {
                result = Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

            return result;
        }
        public async Task<ResponseModel> Post()
        {
            var httpRequest = HttpContext.Current.Request;
            ResponseModel responseModel = null;
            string fileNames =httpRequest.Form["newFileName"];
            int type = Convert.ToInt32(httpRequest.Form["type"]);
            string uploadedBy = httpRequest.Form["sumittedBy"];
            try
            {
                if (!string.IsNullOrWhiteSpace(fileNames))
                {
                    var studentId = fileNames;

                    if (httpRequest.Files.Count > 0)
                    {
                        foreach (string file in httpRequest.Files)
                        {
                            var postedFile = httpRequest.Files[file];
                            WebImage img = new WebImage(postedFile.InputStream);

                            var fileExte = Path.GetExtension(postedFile.FileName);

                            if (FileCheckingManager.OnlineAdmFileCheck(fileExte))
                            {
                                var makeFileName = "something.jpg";
                                string filelocation = FileCheckingManager.FileUploadLocation();
                                img.Save(filelocation + makeFileName);
                                responseModel = new ResponseModel(message: "File saved sussessfully.",
                                    data: makeFileName);
                            }
                            else
                            {
                                responseModel = new ResponseModel(isSuccess: false,
                                    message: "File type not supported.");
                            }
                        }
                    }
                    else
                    {
                        responseModel = new ResponseModel(isSuccess: false, message: "No File to upload");
                    }
                }
            }

            catch (Exception e)
            {
                responseModel = new ResponseModel(isSuccess: false, message: "Error", exception: e);
            }
            return responseModel;
        }
    }
}
