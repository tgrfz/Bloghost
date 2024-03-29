﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bloghost.Domain
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
        public string AuthorId { get; set; }
        public string Address { get; set; }
        public Blog()
        {
            CreateTime = DateTime.Now;
        }
    }
}
