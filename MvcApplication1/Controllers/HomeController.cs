using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //float rv = -1;
            //var browser = Request.Browser; 
            //double IE_ver = browser.MajorVersion + browser.MinorVersion;
            //if (browser.Browser == "InternetExplorer" && (browser.MajorVersion + browser.MinorVersion)==8 )
            //{

            //    ViewBag.Message = "this is IE"+ browser.Browser + IE_ver;
            
            //return View("IEview");
            //}
            //else
            //{
            //    ViewBag.Message = browser.Browser + IE_ver;
            //return View("DefaultView");
            //}

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
