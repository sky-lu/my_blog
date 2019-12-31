using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace my_blog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

    }
}
