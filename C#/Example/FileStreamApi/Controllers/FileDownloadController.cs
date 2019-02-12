using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FileStreamApi.Controllers
{
    public class FileDownloadController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage DownloadImage(string fileName)
        {
            FileStream fs = new FileStream(@"E:\Document\0_PersonalDocument\996_PrivatePictures\Girl.png", FileMode.Open, FileAccess.Read);
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StreamContent(fs)
            };
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
            return response;
        }
    }
}
