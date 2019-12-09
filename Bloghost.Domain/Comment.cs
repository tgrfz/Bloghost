using System;
using System.Collections.Generic;
using System.Text;

namespace Bloghost.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public DateTime CreateTime { get; set; }
        public User Author { get; set; }

        public Comment()
        {
            CreateTime = DateTime.Now;
        }
    }
}
