using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM_8N24RoutingStateModelBinder.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpPost]
        public ActionResult Insert()
        {
            return View();
        }
    }
}