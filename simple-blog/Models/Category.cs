using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace simple_blog.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
    }
}