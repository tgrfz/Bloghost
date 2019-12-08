using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bloghost.Infrastructure
{
    public class BloghostContext : DbContext
    {
        public BloghostContext(DbContextOptions<BloghostContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
