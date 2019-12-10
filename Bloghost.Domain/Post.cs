using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Bloghost.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public User Author { get; set; }
        public List<Comment> Comments { get; set; }
        public Post()
        {
            CreateTime = DateTime.Now;
            Comments = new List<Comment>();
        }
    }
}
