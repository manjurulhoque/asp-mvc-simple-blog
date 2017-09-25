using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace simple_blog.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public Post()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
    }
}