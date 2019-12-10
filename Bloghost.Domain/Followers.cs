using System;
using System.Collections.Generic;
using System.Text;

namespace Bloghost.Domain
{
    public class Followers
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
        public Followers()
        {
            Users = new List<User>();
        }
    }
}
