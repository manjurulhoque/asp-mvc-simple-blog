using simple_blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace simple_blog.ViewModels
{
    public class PostViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public int? id { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public PostViewModel()
        {
            id = 0;
        }
        public PostViewModel(Post post)
        {
            id = post.id;
            CategoryId = post.CategoryId;
            title = post.title;
            description = post.description;
        }

    }
}