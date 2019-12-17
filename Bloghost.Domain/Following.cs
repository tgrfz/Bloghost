using System;
using System.Collections.Generic;
using System.Text;

namespace Bloghost.Domain
{
    public class Following
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
        public Following()
        {
            Users = new List<User>();
        }
    }
}
