using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCBlog.Controllers
{
    public class BlogController : Controller
    {

        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {

            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {


            return View(id);
        }
    }
}
