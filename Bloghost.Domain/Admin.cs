using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Bloghost.Domain
{
    public class Admin
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
    }
}
