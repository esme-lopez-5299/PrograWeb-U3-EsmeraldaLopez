﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace U3_Actividad1_Fruteria.Controllers
{
    public class AdminController : Controller
    {
        [Route("Admin")]
        [Route("Admin/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
