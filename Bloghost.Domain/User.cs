using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Bloghost.Domain
{
    public class User : IdentityUser
    {
        public DateTime CreateTime { get; set; }
        public int FollowersId { get; set; }
        public Followers Followers { get; set; }
        public int FollowingId { get; set; }
        public Following Following { get; set; }
        
        public User() : base()
        {
            CreateTime = DateTime.Now;
        }
    }
}
