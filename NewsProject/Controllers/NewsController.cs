using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsProject.Models;

namespace NewsProject.Controllers
{
    public class NewsController : Controller
    {
        NewsContext context = new NewsContext();
        public IActionResult Index(string newsTitle,string newsCategory)
        {
            var news = context.News.ToList();
            return View(news);
        }
    }
}