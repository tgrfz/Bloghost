using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bloghost.Domain
{
    public class User : IdentityUser
    {
        public DateTime CreateTime { get; set; }
        public User() : base()
        {
            CreateTime = DateTime.Now;
        }
    }
}
