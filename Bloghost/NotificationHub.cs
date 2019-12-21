using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Bloghost.Data;
using Bloghost.Domain;

namespace Bloghost
{
    [Authorize]
    public class NotificationHub : Hub
    {
        private ApplicationDBContext db;
        private readonly UserManager<User> _userManager;

        public NotificationHub(ApplicationDBContext context, UserManager<User> userManager)
        {
            db = context;
            _userManager = userManager;
        }

        public async System.Threading.Tasks.Task Send(string postId)
        {
            var post = db.Posts.Find(postId);
            var user = db.Users.Find(db.Blogs.Find(post.BlogId).AuthorId);
            var userName = Context.User.Identity.Name;
            await Clients.User(user.Id).SendAsync("Notify", userName);
        }
    }
}