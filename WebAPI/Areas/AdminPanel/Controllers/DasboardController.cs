﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Areas.AdminPanel.Controllers
{
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
