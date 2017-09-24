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
            else
            {
                var postIndb = _context.Posts.Single(m => m.id == post.id);

                postIndb.title = post.title;
                postIndb.description = post.description;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Post");
        }

        public ActionResult Details(int id)
        {
            var post = _context.Posts.SingleOrDefault(m => m.id == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var post = _context.Posts.SingleOrDefault(c => c.id == id);

            if (post == null)
                return HttpNotFound();

            return View(post);
        }
    }
}