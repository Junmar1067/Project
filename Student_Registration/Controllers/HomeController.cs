﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student_Registration.Models;

namespace Student_Registration.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            InfoHolder i = new InfoHolder();
            return View(i.Accounts);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Save(Account acc)
        {
            return View();
        }
    }
}
