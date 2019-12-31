using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace my_blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime AddDate { get; set; }
        public string Content { get; set; }
        public int Reviews { get; set; }
        public int PageViews { get; set; }
        public int Likes { get; set; }
    }
}
