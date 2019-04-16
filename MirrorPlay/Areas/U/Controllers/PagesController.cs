using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MirrorPlay.Areas.U.Controllers
{
    public class PagesController : Controller
    {
        // GET: U/Pages
        public ActionResult Index()
        {
            return View();
        }
    }
}