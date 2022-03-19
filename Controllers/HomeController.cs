using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    public ActionResult phone_Details()
        {
            return View();
        } 

        public ActionResult ipods_Details()
        {
            return View();
        }public ActionResult headphone_Details()
        {
            return View();
        }public ActionResult ps3_Details()
        {
            return View();
        }
    }
}