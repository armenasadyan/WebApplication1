using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Code
{
    public class NewAsyncHandler : HttpTaskAsyncHandler
    {
        public override async Task ProcessRequestAsync(HttpContext context)
        {
            WebClient webClient = new WebClient();
            var downloadresult = await
            webClient.DownloadStringTaskAsync("http://www.msn.com");
        }
    }
}