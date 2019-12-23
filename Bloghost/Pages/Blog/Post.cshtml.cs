using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Bloghost.Domain;
using Bloghost.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SignalR.Client;

namespace Bloghost.Pages.Blog
{
    public class PostModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        private readonly ILogger<PostModel> _logger;
        private HubConnection hubConnection;
        public PostModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dBContext, ILogger<PostModel> logger)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dBContext;
            _logger = logger;
            hubConnection = new HubConnectionBuilder().WithUrl("https://localhost:44318/notifications").Build();
            hubConnection.StartAsync();

            hubConnection.On<string, string>("Notify", async (username, postname) =>
            {
                await Response.WriteAsync($"<script>var notification = new Notification('{username} commented post {postname}');</script>");
            });
        }

        public Post Post { get; set; }
        public Domain.Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            public string CommentContent { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet(string blogAddress, string url)
        {
            try
            {
                Post = db.Posts.Where(x => x.Url == url).First();
                Blog = db.Blogs.Find(Post.BlogId);
            }
            catch
            {
                return StatusCode(404);
            }
            Comments = db.Comments.Where(x => x.PostId == Post.Id).OrderBy(x => x.CreateTime).ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostCommentAsync(string blogAddress, string url)
        {
            try
            {
                Post = db.Posts.Where(x => x.Url == url).First();
                Blog = db.Blogs.Find(Post.BlogId);
                Comments = db.Comments.Where(x => x.PostId == Post.Id).OrderBy(x => x.CreateTime).ToList();
            }
            catch
            {
                return StatusCode(404);
            }
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                var comm = new Comment { AuthorId = user.Id, Content = Input.CommentContent, PostId = Post.Id };
                db.Comments.Add(comm);
                await db.SaveChangesAsync();
                _logger.LogInformation("User created a new comment.");

                await hubConnection.InvokeAsync("Send", user.UserName, Post.Title);

                return RedirectToAction("OnGet");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(string blogAddress, string url)
        {
            try
            {
                Post = db.Posts.Where(p => p.Url == url).First();
            }
            catch
            {
                return StatusCode(404);
            }
            var comments = db.Comments.Where(x => x.PostId == Post.Id).ToList();
            foreach (var comm in comments)
            {
                db.Comments.Remove(comm);
            }
            db.Posts.Remove(Post);
            await db.SaveChangesAsync();
            _logger.LogInformation("User deleted post.");
            return RedirectToPagePermanent("/Blog/Index", new { address = blogAddress });
        }

        public async Task<IActionResult> OnPostDeleteCommentAsync(string blogAddress, string url, string commId)
        {
            var comment = db.Comments.Find(Int32.Parse(commId));
            db.Comments.Remove(comment);
            await db.SaveChangesAsync();
            _logger.LogInformation("User deleted comment.");
            return RedirectToAction("OnGet", new { blogAddress = blogAddress, url = url });
        }
    }
}