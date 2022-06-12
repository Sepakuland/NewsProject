using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsProject.Models;

namespace NewsProject.Controllers
{
    public class MoreAboutNewsController : Controller
    {
        NewsContext context = new NewsContext();
        public IActionResult Edit(int id)
        {
            News news = context.News.Find(id);
            return View(news);
        }
        [HttpPost]
        public IActionResult Edit(News news)
        {
            context.News.Update(news);
            return RedirectToAction("index","News");
        }
    }
}