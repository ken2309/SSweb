﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSWeb.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
