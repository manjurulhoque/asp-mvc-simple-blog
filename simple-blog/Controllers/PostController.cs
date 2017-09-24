using simple_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simple_blog.Controllers
{
    public class PostController : Controller
    {
        private BlogDb _context;

        public PostController()
        {
            _context = new BlogDb();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Post
        public ActionResult Index()
        {
            var posts = _context.Posts.ToList();
            return View(posts);
        }
        
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Post post)
        {
            if (post.id == 0)
            {
                _context.Posts.Add(post);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Post");
        }
    }
}