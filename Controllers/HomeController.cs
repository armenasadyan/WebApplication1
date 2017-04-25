using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resources;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult IsUserAvailable(string username)
        {///////////////////
            //if (!WebSecurity.UserExists(username))
            //{
            //    return Json(true, JsonRequestBehavior.AllowGet);
            //}
            string suggestedUID = String.Format(CultureInfo.InvariantCulture,
            "{0} is not available.", username);
            for (int i = 1; i < 100; i++)
            {
            //    string altCandidate = username + i.ToString();
            //    if (!WebSecurity.UserExists(altCandidate))
            //    {
            //        suggestedUID = String.Format(CultureInfo.InvariantCulture,
            //        "{0} is not available. Try {1}.", username, altCandidate);
            //        break;
            //    }
            }
            return Json(suggestedUID, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}