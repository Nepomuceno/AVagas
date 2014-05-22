using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AVagas.Core.Data;
using AVagas.Core.Model;
using Newtonsoft.Json;

namespace AVagas.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }
        public ActionResult Index()
        {
            var url = string.Format("{0}{1}", ConfigurationManager.AppSettings["ApiUrl"], "/api/Vagas");
            return View((object)url);
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