﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class FanController : Controller
    {
        // GET: Fan
        public ActionResult Index()
        {
            return View();
        }
    }
}