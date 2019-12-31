using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace my_blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; }
        public int ParentId { get; set; }
    }
}
