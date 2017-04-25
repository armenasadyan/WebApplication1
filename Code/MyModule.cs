using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Code
{
    public class MyModule : IHttpModule
    {
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            EventHandlerTaskAsyncHelper helper = new EventHandlerTaskAsyncHelper(ScrapePage);
            context.AddOnPostAuthorizeRequestAsync(
            helper.BeginEventHandler, helper.EndEventHandler);
        }

        private async Task ScrapePage(object caller, EventArgs e)
        {
            WebClient webClient = new WebClient();
            var downloadresult = await webClient.DownloadStringTaskAsync("http://www.msn.com");
        }
    }
}