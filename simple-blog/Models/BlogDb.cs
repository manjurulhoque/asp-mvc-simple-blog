using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace simple_blog.Models
{
    public class BlogDb : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}