﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewsProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string userName,string passWord)
        {
            if (userName=="a@a" && passWord == "123")
            {
                return RedirectToAction("index", "news");
            }
            return RedirectToAction("Login");
        }
    }
}