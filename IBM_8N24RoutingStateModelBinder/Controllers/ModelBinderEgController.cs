﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IBM_8N24RoutingStateModelBinder.Controllers
{
    public class ModelBinderEgController : Controller
    {


        public ActionResult DataSourceModelBinder( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult DataSourceModelBinder( string URI_QS , string id, Models.BookTitle FromForm   )
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(new Models.BookTitle());
        }

        [HttpPost]
        public ActionResult Index(Models.BookTitle Book)
        {
            string st = this.Request.Form.Get("Day");

            if (ModelState.IsValid)
            {

            }
            return View();
        }





        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        // 
        public ActionResult Create(FormCollection demo, [Bind(Prefix = "chksource")] List<string> lst, string[] chksource)
        {
            return View();
        }


        public ActionResult AddEmployee()
        {
            return View(new Models.Employee());

        }

        [HttpPost]

        public ActionResult AddEmployee(Models.Employee emp, FormCollection col, string EmpName, [Bind(Exclude = "EmpID,EmpName")] Models.Employee objemp, [Bind(Include = "EmpID,EmpName")] Models.Employee objemp3)
        {
            Models.Employee objone = new Models.Employee();

            this.UpdateModel(objone);



            return View();

        }



    }
}