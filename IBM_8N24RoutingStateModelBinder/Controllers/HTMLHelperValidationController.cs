using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM_8N24RoutingStateModelBinder.Controllers
{
    public class HTMLHelperValidationController : Controller
    {
        // GET: HTMLHelperValidation
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Student student )
        {

            if (ModelState.IsValid)
            {


            }




            return View();
        }
    }
}