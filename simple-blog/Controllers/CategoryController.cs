using simple_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simple_blog.Controllers
{
    public class CategoryController : Controller
    {
        private BlogDb _context;

        public CategoryController()
        {
            _context = new BlogDb();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Category category)
        {
            if (category.id == 0)
            {
                _context.Categories.Add(category);
            }
            else
            {
                var catIndb = _context.Categories.Single(m => m.id == category.id);

                catIndb.name = category.name;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Post");
        }
    }
}