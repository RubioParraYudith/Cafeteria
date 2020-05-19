using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Café.Controllers
{
    public class PostresController : Controller
    {
        // GET: Postres
        public ActionResult Index()
        {
            return View();
        }
    }
}