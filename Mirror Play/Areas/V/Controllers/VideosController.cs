using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirror_Play.Areas.V.Controllers
{
    public class VideosController : Controller
    {
        // GET: V/Videos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }
    }
}