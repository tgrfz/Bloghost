using System;
using System.Collections.Generic;
using System.Text;

namespace Bloghost.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }     
        //public List<Post> Posts { get; set; }
        //public List<Comment> Comments { get; set; }
        //public List<User> Followers { get; set; }
        //public List<User> Following { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public User()
        {
            CreateTime = DateTime.Now;
            //Posts = new List<Post>();
            //Comments = new List<Comment>();
            //Followers = new List<User>();
            //Following = new List<User>();
        }
    }
}
