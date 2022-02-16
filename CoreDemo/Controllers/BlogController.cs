using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var model = bm.GetBlogListWithCategory();
            return View(model);
        }
        public IActionResult BlogReadAll(int id) {

            ViewBag.id = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
    }
}
//50.derste kaldım..