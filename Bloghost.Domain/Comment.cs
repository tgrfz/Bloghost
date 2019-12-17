using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Bloghost.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public DateTime CreateTime { get; set; }
        public string AuthorId { get; set; }
        public Comment()
        {
            CreateTime = DateTime.Now;
        }
    }
}
